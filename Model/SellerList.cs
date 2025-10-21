using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SellerList: List<Seller>
    {
        public SellerList() { }
        public SellerList(IEnumerable<Seller> list) : base(list) { }
        public SellerList(IEnumerable<BaseEntity> list) : base(list.Cast<Seller>().ToList()) { }
    }
}
