using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Follower : BaseEntity
    {
        private User idFollower;
        private User idFollowed;

        public User IdFollower { get => idFollower; set => idFollower = value; }
        public User IdFollowed { get => idFollowed; set => idFollowed = value; }
        public override string ToString()
        {
            return base.ToString() +"@"+ idFollower.UserName+ " follows @"+idFollowed.UserName;
        }
    }
}
