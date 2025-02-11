using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Data.DataOrEntities
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }

        public DateTime CreateAt { get; set; }= DateTime.Now;
    }
}
