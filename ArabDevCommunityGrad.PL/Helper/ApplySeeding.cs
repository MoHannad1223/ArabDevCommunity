using ArabDev.Data.Contexts;
using ArabDev.Repository;
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
