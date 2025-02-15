using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Data.DataOrEntities
{
    public class User_Learning:BaseEntity<int>
    {
        public List<string> LearningNames { get; set; } = new List<string>();
        public User Users { get; set; }
      
        public int UserId { get; set; }
    }
}
