using Model;
using System;
using System.Collections.Generic;
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
    }
}
