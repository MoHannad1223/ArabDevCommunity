using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Data.DataOrEntities
{
    public class Comment:BaseEntity<int>
    {
       
       public string Text{ get; set; }
        public User User { get; set; }
        public int? UserId { get; set; }
        

        public Post Post{ get; set; }
         public int? PostId { get; set; }

        public PodCast PodCast { get; set; }
        public int? PodCastId { get; set; }
       





    }
}
