using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Data.DataOrEntities
{
    public class User:BaseEntity<int>
    {

        
        
        public string UserName { get; set; }

        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Job { get; set; }

        public string PictureUrl { get; set; }

        public string Interests { get; set; }

        public List<string> Follower { get; set; } = new List<string>();

        public List<string> Following { get; set; } = new List<string>();

         public ICollection <Post> Post { get; set; }= new List<Post>();
        [ForeignKey("PostId")]
        public int PostId { get; set; }
        public ICollection <User_Learning> User_Learnings { get; set; } = new List<User_Learning>();
        [ForeignKey("UserLearningId")]
        public int UserLearningId {  get; set; }
        [ForeignKey("SkillsId")]
        public int SkillsId { get; set; }
        public ICollection<Skills> Skills { get; set; } = new List<Skills>();





    }
}
