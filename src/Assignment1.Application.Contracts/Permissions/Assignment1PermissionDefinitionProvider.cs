using Assignment1.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Assignment1.Permissions;

public class Assignment1PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Assignment1Permissions.GroupName);

        var hrPermission = myGroup.AddPermission(Assignment1Permissions.HR, L("Permission:HR"));

        //Define your own permissions here. Example:
        //myGroup.AddPermission(Assignment1Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Assignment1Resource>(name);
    }
}
