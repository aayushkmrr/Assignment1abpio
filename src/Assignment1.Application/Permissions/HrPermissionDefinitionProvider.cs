using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Authorization.Permissions;

namespace Assignment1.Permissions
{
    public class HrPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup("HR");

            myGroup.AddPermission("HR_employee_Create");
        }
    }
}
