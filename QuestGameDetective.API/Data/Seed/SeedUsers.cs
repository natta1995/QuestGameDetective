using Microsoft.AspNetCore.Identity;
using QuestGameDetective.API.Models;

namespace QuestGameDetective.API.Data
{
    public static class SeedUsers
    {
        public static async Task SeedAsync(IServiceProvider services)
        {
            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

            var adminEmail = "admin@test.com";
            var userEmail = "user@test.com";

            if (await userManager.FindByEmailAsync(adminEmail) == null)
            {
                var admin = new ApplicationUser
                {
                    UserName = "AdminPlayer",
                    Email = adminEmail
                };

                var result = await userManager.CreateAsync(admin, "Admin123!"); //Password

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "Admin");
                }
            }

            if (await userManager.FindByEmailAsync(userEmail) == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "UserPlayer",
                    Email = userEmail
                };

                var result = await userManager.CreateAsync(user, "User123!"); // Password

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "User");
                }
            }
        }
    }
}