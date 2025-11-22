using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
            u.Country = CountryDB.SelectById(int.Parse(reader["country"].ToString()));
            u.City = reader["City"].ToString();
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

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            User u = entity as User;
            if (u != null)
            {
                string sqlStr = "DELETE FROM user where id=@pid";

                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@pid", u.Id));


            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            User u = entity as User;
            if (u != null)
            {
                string sqlStr = "INSERT INTO [user] " +
                         "(userName, pass, country, city, street, streetNumber, birthDate, profilePic, instaLink, tiktokLink, facebookLink, name) " +
                         "VALUES (@uName, @pass, @country, @city, @street, @streetNumber, @birthDate, @profilePic, @instaLink, @tiktokLink, @facebookLink, @name)";


                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@uName", u.UserName));
                command.Parameters.Add(new OleDbParameter("@pass", u.Pass));
                command.Parameters.Add(new OleDbParameter("@country", u.Country.Id));
                command.Parameters.Add(new OleDbParameter("@city", u.City));
                command.Parameters.Add(new OleDbParameter("@street", u.Street));
                command.Parameters.Add(new OleDbParameter("@streetNumber", u.StreetNumber));
                command.Parameters.Add(new OleDbParameter("@birthDate", u.BirthDate));
                command.Parameters.Add(new OleDbParameter("@profilePic", u.ProfilePic));
                command.Parameters.Add(new OleDbParameter("@instaLink", u.InstaLink));
                command.Parameters.Add(new OleDbParameter("@tiktokLink", u.TiktokLink));
                command.Parameters.Add(new OleDbParameter("@facebookLink", u.FacebookLink));
                command.Parameters.Add(new OleDbParameter("@name", u.Name));
                command.Parameters.Add(new OleDbParameter("@id", u.Id));

            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            User u = entity as User;
            if (u != null)
            {
                string sqlStr = $"UPDATE [user] SET " +
                       "userName=@uName, " +
                       "pass=@pass, " +
                       "country=@country, " +
                       "city=@city, " +
                       "street=@street, " +
                       "streetNumber=@streetNumber, " +
                       "birthDate=@birthDate, " +
                       "profilePic=@profilePic, " +
                       "instaLink=@instaLink, " +
                       "tiktokLink=@tiktokLink, " +
                       "facebookLink=@facebookLink, " +
                       "name=@name " +
                       "WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@uName", u.UserName));
                command.Parameters.Add(new OleDbParameter("@pass", u.Pass));
                command.Parameters.Add(new OleDbParameter("@country", u.Country.Id));
                command.Parameters.Add(new OleDbParameter("@city", u.City));
                command.Parameters.Add(new OleDbParameter("@street", u.Street));
                command.Parameters.Add(new OleDbParameter("@streetNumber", u.StreetNumber));
                command.Parameters.Add(new OleDbParameter("@birthDate", u.BirthDate));
                command.Parameters.Add(new OleDbParameter("@profilePic", u.ProfilePic));
                command.Parameters.Add(new OleDbParameter("@instaLink", u.InstaLink));
                command.Parameters.Add(new OleDbParameter("@tiktokLink", u.TiktokLink));
                command.Parameters.Add(new OleDbParameter("@facebookLink", u.FacebookLink));
                command.Parameters.Add(new OleDbParameter("@name", u.Name));
                command.Parameters.Add(new OleDbParameter("@id", u.Id));
            }
        }
    }
}
