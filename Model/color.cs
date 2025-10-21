using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Color : BaseEntity
    {
        private string colorName;
        private string rgbCode;

        public string ColorName { get => colorName; set => colorName = value; }
        public string RgbCode { get => rgbCode; set => rgbCode = value; }
        public override string ToString()
        {
            return base.ToString() + colorName +" - "+ rgbCode;
        }
    }
}
