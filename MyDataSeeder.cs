using Volo.Abp.Authorization.Roles;
using Volo.Abp.Identity;
using Volo.Abp.Threading;
using System.Threading.Tasks;

namespace Assignment1.seed
{
    public class MyDataSeeder
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        // Constructor injection for RoleManager
        public MyDataSeeder(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task SeedAsync()
        {
            // Call the method to create the HR role and assign permissions
            await CreateRoleAsync(Assignment1Permissions.HR, "HR");
            // You can also create other roles here
            // await CreateRoleAsync(Assignment1Permissions.Admin, "Admin");
        }

        // Helper method to create roles and assign permissions
        private async Task CreateRoleAsync(string permission, string roleName)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role == null)
            {
                // Create a new role if it doesn't exist
                role = new IdentityRole(roleName);
                await _roleManager.CreateAsync(role);
            }

            // Assign permissions to the role (you can add more permissions as needed)
            await _roleManager.SetPermissionsAsync(role, new[] { permission, Assignment1Permissions.ManageEmployees, Assignment1Permissions.ViewPayroll });
        }
    }
}
