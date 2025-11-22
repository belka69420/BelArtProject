using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class SellerDB : UserDB
    {
        
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
            
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Seller s = entity as Seller;
            if (s != null)
            {
                string sqlStr = "DELETE FROM seller where id=@pid";

                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@pid", s.Id));


            }
        }

        public virtual void Delete(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                deleted.Add(new ChangeEntity(this.CreateDeletedSQL, entity));
                deleted.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Seller s = entity as Seller;
            if (s != null)
            {
                string sqlStr = "INSERT INTO seller " +
                       "        (about, messages, backgroundPic, artistName, sellerTag1, sellerTag2, sellerTag3,id) " +
                       "VALUES (@about, @messages, @backgroundPic, @artistName, @sellerTag1, @sellerTag2, @sellerTag3,@id)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@about", s.About));
                command.Parameters.Add(new OleDbParameter("@messages", s.Messages));
                command.Parameters.Add(new OleDbParameter("@backgroundPic", s.BackgroundPic));
                command.Parameters.Add(new OleDbParameter("@artistName", s.ArtistName));
                command.Parameters.Add(new OleDbParameter("@sellerTag1", s.SellerTag1));
                command.Parameters.Add(new OleDbParameter("@sellerTag2", s.SellerTag2));
                command.Parameters.Add(new OleDbParameter("@sellerTag3", s.SellerTag3));
                command.Parameters.Add(new OleDbParameter("@id", s.Id));

            }
        }
        public override void Insert(BaseEntity entity)
        {
            BaseEntity reqEntity = this.NewEntity();
            if (entity != null & entity.GetType() == reqEntity.GetType())
            {
                inserted.Add(new ChangeEntity(this.CreateInsertdSQL, entity));
            }
            
        }
        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Seller s = entity as Seller;
            if (s != null)
            {
                string sqlStr = "UPDATE seller SET about=@about, messages=@messages, backgroundPic=@backgroundPic, " +
                                "artistName=@artistName, sellerTag1=@sellerTag1, sellerTag2=@sellerTag2, sellerTag3=@sellerTag3 " +
                                "WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@about", s.About));
                command.Parameters.Add(new OleDbParameter("@messages", s.Messages));
                command.Parameters.Add(new OleDbParameter("@backgroundPic", s.BackgroundPic));
                command.Parameters.Add(new OleDbParameter("@artistName", s.ArtistName));
                command.Parameters.Add(new OleDbParameter("@sellerTag1", s.SellerTag1));
                command.Parameters.Add(new OleDbParameter("@sellerTag2", s.SellerTag2));
                command.Parameters.Add(new OleDbParameter("@sellerTag3", s.SellerTag3));
                command.Parameters.Add(new OleDbParameter("@id", s.Id));
            }
        }
        public override void Update(BaseEntity entity)
        {
            Seller Seller = entity as Seller;
            if (Seller != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }

    }
}
