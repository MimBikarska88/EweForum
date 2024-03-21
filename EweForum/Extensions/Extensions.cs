using EweForum.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Specialized;
using System.Configuration;

namespace System.Data.Services.Providers
{
    public static class Extensions
    {
        public static async Task CreateRoles(this  IServiceProvider serviceProvider, IConfiguration configuration)
        {
            //initializing custom roles 
            
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<ForumUser>>();
            string[] roleNames = { "Admin", "User" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                // ensure that the role does not exist
                if (!roleExist)
                {
                    //create the roles and seed them to the database: 
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            // find the user with the admin email 
            var _user = await UserManager.FindByEmailAsync(configuration["Admin:email"]);
            //pass test_p@$$w0rd
            // check if the user exists
            if (_user == null)
            {
                //Here you could create the super admin who will maintain the web app
                var poweruser = new ForumUser
                {
                    UserName = configuration["Admin:username"],
                    Email = configuration["Admin:email"],
                    CreatedOn = DateTime.UtcNow,
                    ModifiedOn = DateTime.UtcNow,
                    CountryId = "NONE",
                };
                string adminPassword = configuration["Admin:password"];

                var createPowerUser = await UserManager.CreateAsync(poweruser, adminPassword);
                if (createPowerUser.Succeeded)
                {
                    //here we tie the new user to the role
                    await UserManager.AddToRoleAsync(poweruser, "Admin");

                }
            }
        }
    }
}
