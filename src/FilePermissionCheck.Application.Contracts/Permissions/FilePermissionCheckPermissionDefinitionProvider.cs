using FilePermissionCheck.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FilePermissionCheck.Permissions;

public class FilePermissionCheckPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FilePermissionCheckPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(FilePermissionCheckPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FilePermissionCheckResource>(name);
    }
}
