using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Data.DataOrEntities
{
   public class Likes:BaseEntity<int>
    {
       public List<string> Interacting {  get; set; }=new List<string>();
        public PodCast PodCast { get; set; }
        public int PodCastId { get; set; }  
        
        public Post Post { get; set; }
        public int? PostId {  get; set; }
        //---------------------------------
        public User Users { get; set; }
        public int? UserId { get; set; }


        




    }
}
