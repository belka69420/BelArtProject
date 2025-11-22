using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
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

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Material m = entity as Material;
            if (m != null)
            {
                string sqlStr = "DELETE FROM material where id=@pid";

                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@pid", m.Id));


            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Material m = entity as Material;
            if (m != null)
            {
                string sqlStr = $"Insert INTO material  (material) VALUES (@mName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@mName", m.MaterialName));

            }
        }
        

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Material m = entity as Material;
            if (m != null)
            {
                string sqlStr = $"UPDATE material  SET material=@mName WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@mName", m.MaterialName));
                command.Parameters.Add(new OleDbParameter("@id", m.Id));
            }
        }
    }
}
