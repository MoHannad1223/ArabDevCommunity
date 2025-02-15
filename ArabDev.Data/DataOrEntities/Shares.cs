using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Data.DataOrEntities
{
  public class Shares:BaseEntity<int>
    {
        public DateTime ShareTime { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        

        public Post Post { get; set; }
        public int PostId { get; set; }
        
    }
}
