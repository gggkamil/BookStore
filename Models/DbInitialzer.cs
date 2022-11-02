using E_commerce.Areas.Identity.Data;
using E_commerce.Data;
using Microsoft.AspNetCore.Identity;

namespace E_commerce.Models
{
    public static class DbInitialzer
    {
        public static async Task InitialzeAsync(E_commerceContext context, IServiceProvider serviceProvider, UserManager<E_commerceUser> userManager)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] RoleNames = { "Admin", "User" };
            IdentityResult roleResult;
            foreach(var roleName in RoleNames)
            {
                var roleExists = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExists)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
            string Email = "admin@myecomsite.com";
            string password = "Admin,./123";
            if (userManager.FindByEmailAsync(Email).Result == null)
            {
                E_commerceUser user = new E_commerceUser();
                user.UserName = Email;
                user.Email = Email;
                IdentityResult result = userManager.CreateAsync(user,password).Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user,"Admin").Wait();
                }
            }
        }
    }
}
