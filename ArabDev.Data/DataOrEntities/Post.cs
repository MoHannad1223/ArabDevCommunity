using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArabDev.Data.DataOrEntities
{
    public class Post:BaseEntity<int>
    {

        public string? Describtion { get; set; }

        public string? Title { get; set; }

        public DateTime PostDate { get; set; }

        public int? LikesCount { get; set; }
        public int? CommentCount { get; set; }

        public List <string>? Images  { get; set; }= new List<string>();
        [ForeignKey("UserId")]

        public User User { get; set; }
       
        public int UserId { get; set; }

        public ICollection<Likes> Likes { get; set; }=new List<Likes>();
        public ICollection<Comment> Comments { get; set; }=new List<Comment>();
        public ICollection<Shares> Shares { get; set; } = new List<Shares>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();



    }
}


