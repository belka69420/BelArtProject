using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TagArt : BaseEntity
    {
        private Art idArt;
        private string tagName;

        
        public string TagName { get => tagName; set => tagName = value; }
        internal Art IdArt { get => idArt; set => idArt = value; }

        public override string ToString()
        {
            return base.ToString()+idArt.PieceName+" #"+tagName;
        }
    }
}
