using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using NoWayOut.Data.Entity;

namespace NoWayOut.Data
{
    public static class ApplicationDbInitializer
    {
        public static void SeedUsers(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedAdmin(userManager);
            SeedRegularUser(userManager);
        }

        private static void SeedRegularUser(UserManager<AppUser> userManager)
        {
            if ((userManager.FindByNameAsync("regular").Result) != null)
            {
                var user = new AppUser()
                {
                    UserName = "client",
                    Email = "client@client.com",
                    FirstName = "client",
                    LastName = "client"
                };
                var userCreated = userManager.CreateAsync(user, "client123").Result;

                if (userCreated.Succeeded)
                {
                    var result = userManager.AddToRoleAsync(user, "client123").Result;
                }

            }
        }

        private static void SeedAdmin(UserManager<AppUser> userManager)
        {
            if ((userManager.FindByNameAsync("administrator").Result) != null)
            {
                var adminUser = new AppUser()
                {
                    UserName = "administrator",
                    Email = "administrator@administrator.com",
                    FirstName = "administrator",
                    LastName = "administrator"
                };
                var adminCreated = userManager.CreateAsync(adminUser, "administrator123").Result;

                if (adminCreated.Succeeded)
                {
                    var result = userManager.AddToRoleAsync(adminUser, "administrator123").Result;
                }
            }
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!(roleManager.RoleExistsAsync("administrator").Result))
            {
                var result = roleManager.CreateAsync(new IdentityRole()
                {
                    Name = "administrator"
                }).Result;

                var result1 = roleManager.CreateAsync(new IdentityRole()
                {
                    Name = "client"
                }).Result;
            }
        }
    }
}