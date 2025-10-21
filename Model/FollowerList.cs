using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FollowerList : List<Follower>
    {
        public FollowerList() { }
        public FollowerList(IEnumerable<Follower> list) : base(list) { }
        public FollowerList(IEnumerable<BaseEntity> list) : base(list.Cast<Follower>().ToList()) { }
    }
}
