using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ColorList:List<Color>
    {
        public ColorList() { }
        public ColorList(IEnumerable<Color> list) : base(list) { }
        public ColorList(IEnumerable<BaseEntity> list) : base(list.Cast<Color>().ToList()) { }

    }
}
