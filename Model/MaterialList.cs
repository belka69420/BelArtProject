using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MaterialList: List<Material>
    {
        public MaterialList() { }
        public MaterialList(IEnumerable<Material> list) : base(list) { }
        public MaterialList(IEnumerable<BaseEntity> list) : base(list.Cast<Material>().ToList()) { }
    }
}
