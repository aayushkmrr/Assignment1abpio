using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Authorization.Roles;
using Volo.Abp.PermissionManagement;
using Volo.Abp.Domain.Repositories;
using MyApp.Authorization;

namespace MyApp.Seed
{
    public class RolePermissionSeeder : ApplicationService
    {
        private readonly RoleManager _roleManager;
        private readonly PermissionManager _permissionManager;

        public RolePermissionSeeder(RoleManager roleManager, PermissionManager permissionManager)
        {
            _roleManager = roleManager;
            _permissionManager = permissionManager;
        }

        public async Task SeedAsync()
        {
            // Define your roles
            var hrManagerRole = await _roleManager.FindByNameAsync("HRManager");

            if (hrManagerRole == null)
            {
                // Create the HRManager role if it does not exist
                hrManagerRole = await _roleManager.CreateAsync(new IdentityRole("HRManager"));
            }

            // Grant the HR_employee_Create permission to the HRManager role
            var permission = await _permissionManager.GetAsync("HR_employee_Create");

            // Check if permission is already assigned to the role
            var roleGrantedPermissions = await _permissionManager.GetGrantedPermissionsAsync(hrManagerRole);
            if (!roleGrantedPermissions.Contains(permission))
            {
                // Assign the permission to the role
                await _permissionManager.GrantAsync(hrManagerRole, permission);
            }
        }
    }
}
