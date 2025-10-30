using Model;
using System;
using System.Collections.Generic;
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



    }
}
