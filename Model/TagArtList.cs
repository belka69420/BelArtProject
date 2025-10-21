using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TagArtList:List<TagArt>
    {
        public TagArtList() { }
        public TagArtList(IEnumerable<TagArt> list) : base(list) { }
        public TagArtList(IEnumerable<BaseEntity> list) : base(list.Cast<TagArt>().ToList()) { }
    }
}
