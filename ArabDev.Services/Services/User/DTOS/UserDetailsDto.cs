using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Services.Services.User.DTOS
{
   public class UserDetailsDto
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Job { get; set; }

        public DateTime CreatAt { get; set; }

    }
}
