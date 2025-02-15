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
        public User User { get; set; }
        public int FollowingId { get; set; }
        public int FollowerId { get; set; }

    }
}
