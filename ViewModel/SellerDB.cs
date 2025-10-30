using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class SellerDB : UserDB
    {
        //public UserList SelectAll()
        //{
        //    command.CommandText = $"SELECT seller.about, seller.backgroundPic, seller.messages, seller.artistName, seller.sellerTag1, seller.sellerTag2, seller.sellerTag3, [user].id, [user].useName, [user].pass, [user].country, [user].city, [user].street, [user].streetNumber, \r\n                  [user].birthDate, [user].profilePic, [user].instaLink, [user].tiktokLink, [user].facebookLink, [user].name\r\nFROM     (seller INNER JOIN\r\n                  [user] ON seller.id = [user].id AND seller.id = [user].id)";
        //    UserList uList = new UserList(base.Select());
        //    return uList;
        //}
        public SellerList SelectAll()
        {
            command.CommandText = $"SELECT seller.about, seller.backgroundPic, seller.messages, seller.artistName, seller.sellerTag1, seller.sellerTag2, seller.sellerTag3, [user].id, [user].userName, [user].pass, [user].country, [user].city, [user].street, [user].streetNumber, \r\n                  [user].birthDate, [user].profilePic, [user].instaLink, [user].tiktokLink, [user].facebookLink, [user].name\r\nFROM     (seller INNER JOIN\r\n                  [user] ON seller.id = [user].id AND seller.id = [user].id)";
            SellerList sList = new SellerList(base.Select());
            return sList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Seller s = entity as Seller;
            s.About = reader["about"].ToString();
            s.Messages = (bool)reader["messages"];
            s.BackgroundPic = reader["backgroundPic"].ToString();
            s.ArtistName = reader["artistName"].ToString();
            s.SellerTag1 = reader["sellerTag1"].ToString();
            s.SellerTag2 = reader["sellerTag2"].ToString();
            s.SellerTag3 = reader["sellerTag3"].ToString();

            base.CreateModel(entity);
            return s;
        }
        public override BaseEntity NewEntity()
        {
            return new Seller();
        }
        static private SellerList list = new SellerList();
        public static Seller SelectById(int id)
        {
            SellerDB db = new SellerDB();
            list = db.SelectAll();

            Seller g = list.Find(item => item.Id == id);
            return g;
            //Seller s = null;
            //string sql = "SELECT * FROM Seller WHERE id = " + id;
            //DataTable dt = DBHelper.GetDataTable(sql);

            //if (dt.Rows.Count > 0)
            //{
            //    DataRow row = dt.Rows[0];
            //    s = new Seller();
            //    s.Id = (int)row["id"];
            //    s.About = row["about"].ToString();
            //    s.Messages = (bool)row["messages"];
            //    s.BackgroundPic = row["backgroundPic"].ToString();
            //    s.ArtistName = row["artistName"].ToString();
            //    s.SellerTag1 = row["sellerTag1"].ToString();
            //    s.SellerTag2 = row["sellerTag2"].ToString();
            //    s.SellerTag3 = row["sellerTag3"].ToString();

            //    // If your Seller also has a User ID
            //    s.idUser = UserDB.SelectById((int)row["idUser"]);
            //}

            //return s;
        }
    }
}
