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

        public string Describtion { get; set; }

        public string Title { get; set; }

        public DateTime PostDate { get; set; }

        public List<string> Likes { get; set; } = new List<string>();

       public string Img { get; set; }

       public ICollection <Comment> Comments { get; set; } = new List<Comment>();
        [ForeignKey("CommentId")]
        public int CommentId { get; set; }


    }
}
