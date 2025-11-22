using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
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

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Follower f = entity as Follower;
            if (f != null)
            {
                string sqlStr = "DELETE FROM follower where id=@pid";

                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@pid", f.Id));


            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {

            Follower f = entity as Follower;
            if (f != null)
            {
                string sqlStr = "INSERT INTO follower (idFollower, idFollowed) VALUES (@idFollower, @idFollowed)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@idFollower", f.IdFollower.Id));
                command.Parameters.Add(new OleDbParameter("@idFollowed", f.IdFollowed.Id));
               
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Follower f = entity as Follower;
            if (f != null)
            {
                string sqlStr = $"UPDATE follower SET idFollower=@idFollower, idFollowed=@idFollowed WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@idFollower", f.IdFollower.Id));
                command.Parameters.Add(new OleDbParameter("@idFollowed", f.IdFollowed.Id));
                command.Parameters.Add(new OleDbParameter("@id", f.Id));
            }
        }
    }
}
