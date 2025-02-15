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

       

      

         public ICollection <Post> Post { get; set; }= new List<Post>();
        public ICollection<User_Learning> User_Learnings { get; set; } = new List<User_Learning>();
        public List<Follower> Followers { get; set; } = new List<Follower>();
        public ICollection<Skills> Skills { get; set; } = new List<Skills>();
        public ICollection<Likes> Likes { get; set; } = new List<Likes>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<SavedPost> SavedPosts { get; set; } = new List<SavedPost>();
        public ICollection<Shares> Shares { get; set; } = new List<Shares>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public ICollection<Message> Messages { get; set; } = new List<Message>();






    }
}
