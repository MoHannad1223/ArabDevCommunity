using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Data.DataOrEntities
{
    public class Message:BaseEntity<int>
    {
        public string MessageText {  get; set; }
        public bool IsRead { get; set; }
        public User User { get; set; }
       
        public int SenderId {  get; set; }
        public int ReceiverId { get; set; }
    }
}
