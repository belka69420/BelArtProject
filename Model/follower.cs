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
            if (idFollower == null)
                idFollower = new User();
            if (idFollower.UserName == null)
                idFollower.UserName = "";
            if (idFollowed == null)
                idFollowed = new User();
            if (idFollowed.UserName == null)
                idFollowed.UserName = "";
            return "@"+ idFollower.UserName + " follows @"+ idFollowed.UserName;
        }
    }
}
