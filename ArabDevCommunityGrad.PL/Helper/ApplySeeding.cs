using ArabDev.Data.Contexts;
using ArabDev.Data.Identity;
using ArabDev.Repository;
using ArabDev.Repository.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ArabDevCommunityGrad.PL.Helper
{
    public class ApplySeeding
    {
        public static async Task ApplySeedingAsync(WebApplication app) 
        {
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();
                try
                {
                    var context = services.GetRequiredService<ArabDevDbContext>();
                    await context.Database.MigrateAsync();

                    var identityDbcontext = services.GetRequiredService<AppIdentityDbContext>();
                    await identityDbcontext.Database.MigrateAsync();
                    var UserManager = services.GetRequiredService<UserManager<AppUser>>();

                    await AppIdentityDbContextSeed.SeedUserAsnc(UserManager,context);
                    await DevContextSeeding.SeedAsync(context, loggerFactory);
                }
                catch (Exception ex)
                {
                    var logger = loggerFactory.CreateLogger<ApplySeeding>();
                    logger.LogError(ex.Message);
                    if (ex.InnerException != null)
                    {
                        Console.WriteLine($"InnerException: {ex.InnerException.Message}");
                    }
                }
            }

        }
    }
}
