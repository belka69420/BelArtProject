using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ArtDB : BaseDB
    {
        public ArtList SelectAll()
        {
            command.CommandText = $"SELECT art.*  FROM    art";
            ArtList aList = new ArtList(base.Select());
            return aList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Art a = entity as Art;
            
            a.IdSeller = SellerDB.SelectById((int)reader["idSeller"]);
           
            a.PicLink1 = reader["picLink1"].ToString();
            a.PicLink2 = reader["picLink2"].ToString();
            a.PicLink3 = reader["picLink3"].ToString();
            a.PicLink4 = reader["picLink4"].ToString();
            a.Country = CountryDB.SelectById((int)reader["country"]);
            a.City = reader["city"].ToString();
            a.Street = reader["street"].ToString();
            a.StreetNumber = reader["streetNumber"].ToString();
            a.PlaceName = reader["placeName"].ToString();
            a.PieceName = reader["pieceName"].ToString();
            a.SelfPickUp = reader["selfPickUp"].ToString();
            a.Price = reader["price"].ToString();
            a.Height = reader["height"].ToString();
            a.Width = reader["width"].ToString();
            a.About = reader["about"].ToString();
            a.Color1 = ColorDB.SelectById((int)reader["color1"]);
            a.Color2 = ColorDB.SelectById((int)reader["color2"]);
            a.Color3 = ColorDB.SelectById((int)reader["color3"]);
            a.Material = MaterialDB.SelectById((int)reader["material"]);

            base.CreateModel(entity);
            return a;
        }
        public override BaseEntity NewEntity()
        {
            return new Art();
        }
        static private ArtList list = new ArtList();
        public static Art SelectById(int id)
        {
            ArtDB db = new ArtDB();
            list = db.SelectAll();

            Art g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Art a = entity as Art;
            if (a != null)
            {
                string sqlStr = "DELETE FROM art where id=@pid";

                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@pid", a.Id));


            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Art a = entity as Art;
            if (a != null)
            {
                string sqlStr = "INSERT INTO art " +
                        "(idSeller, picLink1, picLink2, picLink3, picLink4, country, city, street, streetNumber, placeName, pieceName, selfPickUp, price, height, width, about, color1, color2, color3, material) " +
                        "VALUES (@idSeller, @picLink1, @picLink2, @picLink3, @picLink4, @country, @city, @street, @streetNumber, @placeName, @pieceName, @selfPickUp, @price, @height, @width, @about, @color1, @color2, @color3, @material)";


                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@idSeller", a.IdSeller.Id));
                command.Parameters.Add(new OleDbParameter("@picLink1", a.PicLink1));
                command.Parameters.Add(new OleDbParameter("@picLink2", a.PicLink2));
                command.Parameters.Add(new OleDbParameter("@picLink3", a.PicLink3));
                command.Parameters.Add(new OleDbParameter("@picLink4", a.PicLink4));
                command.Parameters.Add(new OleDbParameter("@country", a.Country.Id));
                command.Parameters.Add(new OleDbParameter("@city", a.City));
                command.Parameters.Add(new OleDbParameter("@street", a.Street));
                command.Parameters.Add(new OleDbParameter("@streetNumber", a.StreetNumber));
                command.Parameters.Add(new OleDbParameter("@placeName", a.PlaceName));
                command.Parameters.Add(new OleDbParameter("@pieceName", a.PieceName));
                command.Parameters.Add(new OleDbParameter("@selfPickUp", a.SelfPickUp));
                command.Parameters.Add(new OleDbParameter("@price", a.Price));
                command.Parameters.Add(new OleDbParameter("@height", a.Height));
                command.Parameters.Add(new OleDbParameter("@width", a.Width));
                command.Parameters.Add(new OleDbParameter("@about", a.About));
                command.Parameters.Add(new OleDbParameter("@color1", a.Color1.Id));
                command.Parameters.Add(new OleDbParameter("@color2", a.Color2.Id));
                command.Parameters.Add(new OleDbParameter("@color3", a.Color3.Id));
                command.Parameters.Add(new OleDbParameter("@material", a.Material.Id));
               
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Art a = entity as Art;
            if (a != null)
            {
                string sqlStr = $"UPDATE art SET " +
                                "idSeller=@idSeller, " +
                                "picLink1=@picLink1, " +
                                "picLink2=@picLink2, " +
                                "picLink3=@picLink3, " +
                                "picLink4=@picLink4, " +
                                "country=@country, " +
                                "city=@city, " +
                                "street=@street, " +
                                "streetNumber=@streetNumber, " +
                                "placeName=@placeName, " +
                                "pieceName=@pieceName, " +
                                "selfPickUp=@selfPickUp, " +
                                "price=@price, " +
                                "height=@height, " +
                                "width=@width, " +
                                "about=@about, " +
                                "color1=@color1, " +
                                "color2=@color2, " +
                                "color3=@color3, " +
                                "material=@material " +
                                "WHERE id=@id";

                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@idSeller", a.IdSeller.Id));
                command.Parameters.Add(new OleDbParameter("@picLink1", a.PicLink1));
                command.Parameters.Add(new OleDbParameter("@picLink2", a.PicLink2));
                command.Parameters.Add(new OleDbParameter("@picLink3", a.PicLink3));
                command.Parameters.Add(new OleDbParameter("@picLink4", a.PicLink4));
                command.Parameters.Add(new OleDbParameter("@country", a.Country.Id));
                command.Parameters.Add(new OleDbParameter("@city", a.City));
                command.Parameters.Add(new OleDbParameter("@street", a.Street));
                command.Parameters.Add(new OleDbParameter("@streetNumber", a.StreetNumber));
                command.Parameters.Add(new OleDbParameter("@placeName", a.PlaceName));
                command.Parameters.Add(new OleDbParameter("@pieceName", a.PieceName));
                command.Parameters.Add(new OleDbParameter("@selfPickUp", a.SelfPickUp));
                command.Parameters.Add(new OleDbParameter("@price", a.Price));
                command.Parameters.Add(new OleDbParameter("@height", a.Height));
                command.Parameters.Add(new OleDbParameter("@width", a.Width));
                command.Parameters.Add(new OleDbParameter("@about", a.About));
                command.Parameters.Add(new OleDbParameter("@color1", a.Color1.Id));
                command.Parameters.Add(new OleDbParameter("@color2", a.Color2.Id));
                command.Parameters.Add(new OleDbParameter("@color3", a.Color3.Id));
                command.Parameters.Add(new OleDbParameter("@material", a.Material.Id));
                command.Parameters.Add(new OleDbParameter("@id", a.Id));
            }
        }
    }
}
