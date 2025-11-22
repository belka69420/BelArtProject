using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ColorDB : BaseDB
    {
        public ColorList SelectAll()
        {
            command.CommandText = $"SELECT color.* FROM     color";
            ColorList groupList = new ColorList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Color c = entity as Color;
            c.ColorName = reader["colorName"].ToString();
            c.RgbCode = reader["rgbCode"].ToString();
            base.CreateModel(entity);
            return c;
        }
        public override BaseEntity NewEntity()
        {
            return new Color();
        }

        static private ColorList list = new ColorList();

        public static Color SelectById(int id)
        {
            ColorDB db = new ColorDB();
            list = db.SelectAll();

            Color g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Color c = entity as Color;
            if (c != null)
            {
                string sqlStr = "DELETE FROM color where id=@pid";

                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@pid", c.Id));
                

            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
           
            Color c = entity as Color;
            if (c != null)
            {
                string sqlStr = "Insert INTO color (ColorName, RgbCode) VALUES (@cName, @rCode)";

                command.CommandText = sqlStr;
              
                command.Parameters.Add(new OleDbParameter("@cName", c.ColorName));
                command.Parameters.Add(new OleDbParameter("@rCode", c.RgbCode));

            }

        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {

            Color c = entity as Color;
            if (c != null)
            {
                string sqlStr = $"UPDATE color  SET colorName=@cName, rgbCode=@rCode WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.ColorName));
                command.Parameters.Add(new OleDbParameter("@rCode", c.RgbCode));

                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }
}
