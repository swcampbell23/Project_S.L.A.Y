﻿using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Project_SLAY.Seeding
{
    public class SeedRoles
    {
        public static async Task AddAllRoles(RoleManager<IdentityRole> roleManager)
        {

            if (await roleManager.RoleExistsAsync("Admin") == false)
            {
                //this code uses the role manager object to create the admin role
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            //if the customer role doesn't exist, add it
            if (await roleManager.RoleExistsAsync("Customer") == false)
            {
                //this code uses the role manager object to create the customer role
                await roleManager.CreateAsync(new IdentityRole("Customer"));
            }

            if (await roleManager.RoleExistsAsync("Employee") == false)
            {
                //this code uses the role manager object to create the customer role
                await roleManager.CreateAsync(new IdentityRole("Employee"));
            }

        }
    }
}
