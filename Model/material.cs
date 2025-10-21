using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Material : BaseEntity
    {
        private string materialName;

        public string MaterialName { get => materialName; set => materialName = value; }
        public override string ToString()
        {
            return base.ToString() + materialName;
        }
    }
}
