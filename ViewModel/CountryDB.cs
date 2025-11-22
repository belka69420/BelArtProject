using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{

    public class CountryDB : BaseDB
    {
        public CountryList SelectAll()
        {
            command.CommandText = $"SELECT country.* FROM country";
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

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Country c = entity as Country;
            if (c != null)
            {
                string sqlStr = "DELETE FROM country where id=@pid";

                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@pid", c.Id));


            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Country c = entity as Country;
            if (c != null)
            {
                string sqlStr = $"Insert INTO country  (CountryName) VALUES (@cName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.CountryName));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Country c = entity as Country;
            if (c != null)
            {
                string sqlStr = $"UPDATE country  SET countryName=@cName WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.CountryName));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }
}
