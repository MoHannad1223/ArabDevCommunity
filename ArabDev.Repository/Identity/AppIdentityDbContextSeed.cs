using ArabDev.Data.Contexts;
using ArabDev.Data.DataOrEntities;
using ArabDev.Data.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabDev.Repository.Identity
{
    public static class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsnc(UserManager<AppUser> userManager,ArabDevDbContext context)
        {
            if (!userManager.Users.Any())
            {
                var appUser = new AppUser()
                {
                    DisplayName = "Esraa Sherif",
                    Email = "esraasherif1042@gmail.com",
                    UserName = "esraa sherif",
                    PhoneNumber = "01063277063"

                };
                var result = await userManager.CreateAsync(appUser, "Pa$$w0rd");
                if (result.Succeeded)
                {
                    // إنشاء User المقابل
                    var user = new User
                    {
                        UserName = appUser.DisplayName,
                        Email = appUser.Email,
                        Password = "Pa$$w0rd", // يمكنك تشفيرها إذا لزم الأمر
                        PhoneNumber = appUser.PhoneNumber,
                        Job = "Software Engineer", // مثال
                        AppUserId = appUser.Id // الربط بين User و AppUser
                    };

                    // إضافة User إلى الجدول الخاص به
                    context.Users.Add(user);
                    await context.SaveChangesAsync();
                }

            }
           
        }
    }
}
