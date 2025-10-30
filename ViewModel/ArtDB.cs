using Model;
using System;
using System.Collections.Generic;
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
            //p.LivingCity = CityDB.SelectById((int)reader["cityCode"]);
            a.IdSeller = SellerDB.SelectById((int)reader["idSeller"]);
            //a.IdSeller = reader["idSeller"].ToString();
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
    }
}
