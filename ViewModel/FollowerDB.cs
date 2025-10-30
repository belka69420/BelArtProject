using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class FollowerDB : BaseDB
    {
        public FollowerList SelectAll()
        {
            command.CommandText = $"SELECT follower.*  FROM  follower";
            FollowerList fList = new FollowerList(base.Select());
            return fList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Follower f = entity as Follower;
            
            f.IdFollower = UserDB.SelectById(int.Parse(reader["idFollower"].ToString()));
            f.IdFollowed = UserDB.SelectById((int)reader["idFollowed"]);

            base.CreateModel(entity);
            return f;
        }
        public override BaseEntity NewEntity()
        {
            return new Follower();
        }
        static private FollowerList list = new FollowerList();
        public static Follower SelectById(int id)
        {
            FollowerDB db = new FollowerDB();
            list = db.SelectAll();

            Follower g = list.Find(item => item.Id == id);
            return g;
        }
    }
}
