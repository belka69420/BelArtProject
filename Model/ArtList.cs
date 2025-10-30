using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ArtList : List<Art>
    {
        public ArtList() { }
        public ArtList(IEnumerable<Art> list) : base(list) { }
        public ArtList(IEnumerable<BaseEntity> list) : base(list.Cast<Art>().ToList()) { }
    }
}
