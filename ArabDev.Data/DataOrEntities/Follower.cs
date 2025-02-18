using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Data.DataOrEntities
{
    public class Follower
    {
      public int FollowerUserId { get; set; }
    public int FollowedUserId { get; set; } 

   
    public User User { get; set; }

    
    //public User FollowedUser { get; set; }



    }
}
