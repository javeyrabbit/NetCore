using search.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace search.Permissions;

public class searchPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(searchPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(searchPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<searchResource>(name);
    }
}
