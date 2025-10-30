using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class UserDB : BaseDB
    {
        public UserList SelectAll()
        {
            command.CommandText = $"SELECT [user].*   FROM   [user]";
            UserList uList = new UserList(base.Select());
            return uList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            User u = entity as User;
           
            u.UserName = reader["userName"].ToString();
            u.Pass = reader["pass"].ToString();
            u.Country = CountryDB.SelectById((int)reader["country"]);
            u.City = reader["city"].ToString();
            u.Street = reader["street"].ToString();
            u.StreetNumber = reader["streetNumber"].ToString();
            u.BirthDate = (DateTime)reader["birthDate"];
            u.ProfilePic = reader["profilePic"].ToString();
            u.InstaLink = reader["instaLink"].ToString();
            u.TiktokLink = reader["tiktokLink"].ToString();
            u.FacebookLink = reader["facebookLink"].ToString();
            u.Name = reader["name"].ToString();

            base.CreateModel(entity);
            return u;
        }
        public override BaseEntity NewEntity()
        {
            return new User();
        }
        static private UserList list = new UserList();
        public static User SelectById(int id)
        {
            UserDB db = new UserDB();
            list = db.SelectAll();

            User g = list.Find(item => item.Id == id);
            return g;
        }
    }
}
