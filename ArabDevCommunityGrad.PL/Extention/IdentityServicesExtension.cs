using ArabDev.Data.Identity;
using ArabDev.Repository.Identity;
using Microsoft.AspNetCore.Identity;

namespace ArabDevCommunityGrad.PL.Extention
{
    public static class IdentityServicesExtension
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection Services)
        {
            Services.AddIdentity<AppUser, IdentityRole>()
                            .AddEntityFrameworkStores<AppIdentityDbContext>();

            Services.AddAuthentication();// usermanger / signinManager / role manager

            return Services;
        }
    }
}
