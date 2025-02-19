using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Data.DataOrEntities
{
    public class Follower:BaseEntity<int>
    {
        [NotMapped]
      public int FollowerUserId { get; set; }
        [NotMapped]
    public int FollowedUserId { get; set; } 

   
    public User UserFollower{ get; set; }
        public User UserFollowed { get; set; }


        //public User FollowedUser { get; set; }



    }
}
