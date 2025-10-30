using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class MaterialDB : BaseDB
    {
        public MaterialList SelectAll()
        {
            command.CommandText = $"SELECT material.*  FROM     material";
            MaterialList groupList = new MaterialList(base.Select());
            return groupList;
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Material m = entity as Material;
            m.MaterialName = reader["material"].ToString();
            base.CreateModel(entity);
            return m;
        }
        public override BaseEntity NewEntity()
        {
            return new Material();
        }
        static private MaterialList list = new MaterialList();
        public static Material SelectById(int id)
        {
            MaterialDB db = new MaterialDB();
            list = db.SelectAll();

            Material g = list.Find(item => item.Id == id);
            return g;
        }
    }
}
