using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{

    public class CountryDB : BaseDB
    {
        public CountryList SelectAll()
        {
            command.CommandText = $"SELECT * FROM country";
            CountryList groupList = new CountryList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Country c = entity as Country;
            c.CountryName = reader["countryName"].ToString();
            base.CreateModel(entity);
            return c;
        }
        public override BaseEntity NewEntity()
        {
            return new Country();
        }
        static private CountryList list = new CountryList();
        public static Country SelectById(int id)
        {
            CountryDB db = new CountryDB();
            list = db.SelectAll();

            Country g = list.Find(item => item.Id == id);
            return g;
        }

    }
}
