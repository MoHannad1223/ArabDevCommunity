using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Data.DataOrEntities
{
    public class BaseEntity<T>
    {
        [Key]
        public T Id { get; set; }

        public DateTime CreateAt { get; set; }= DateTime.Now;
    }
}
