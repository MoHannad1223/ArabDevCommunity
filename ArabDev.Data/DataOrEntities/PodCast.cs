using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Data.DataOrEntities
{
    public class PodCast:BaseEntity<int>
    {
        public  string  PodCastDetails { get; set; }
        public List<string> PodCastUrl { get; set; }=new List<string>();

        public ICollection<Likes> Likes { get; set; } = new List<Likes>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        
    }
}
