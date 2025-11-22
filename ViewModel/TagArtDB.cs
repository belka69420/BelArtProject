using Model;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class TagArtDB : BaseDB
    {
        public TagArtList SelectAll()
        {
            command.CommandText = $"SELECT tagArt.*  FROM   tagArt";
            TagArtList taList = new TagArtList(base.Select());
            return taList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            TagArt ta = entity as TagArt;
            ta.IdArt = ArtDB.SelectById((int)reader["idArt"]);
            ta.TagName = reader["tagName"].ToString();
            base.CreateModel(entity);
            return ta;
        }
        public override BaseEntity NewEntity()
        {
            return new TagArt();
        }
        static private TagArtList list = new TagArtList();
        public static TagArt SelectById(int id)
        {
            TagArtDB db = new TagArtDB();
            list = db.SelectAll();

            TagArt g = list.Find(item => item.Id == id);
            return g;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            TagArt ta = entity as TagArt;
            if (ta != null)
            {
                string sqlStr = "DELETE FROM tagArt where id=@pid";

                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@pid", ta.Id));


            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            TagArt ta = entity as TagArt;
            if (ta != null)
            {
                string sqlStr = "INSERT INTO tagArt (idArt, tagName) VALUES (@iArt, @tName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@iArt", ta.IdArt.Id));
                command.Parameters.Add(new OleDbParameter("@tName", ta.TagName));

            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            TagArt ta = entity as TagArt;
            if (ta != null)
            {
                string sqlStr = $"UPDATE tagArt  SET idArt=@iArt, tagName=@tName WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@iArt", ta.IdArt.Id));
                command.Parameters.Add(new OleDbParameter("@tName", ta.TagName));

                command.Parameters.Add(new OleDbParameter("@id", ta.Id));
            }
        }
    }
}
