using Volo.Abp.Settings;

namespace FilePermissionCheck.Settings;

public class FilePermissionCheckSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(FilePermissionCheckSettings.MySetting1));
    }
}
