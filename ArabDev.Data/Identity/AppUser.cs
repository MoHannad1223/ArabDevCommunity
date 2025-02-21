using ArabDev.Data.DataOrEntities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Data.Identity
{
    public class AppUser:IdentityUser
    {
        public string DisplayName { get; set; }

        public string address { get; set; }
        public User User { get; set; }

    }
}
