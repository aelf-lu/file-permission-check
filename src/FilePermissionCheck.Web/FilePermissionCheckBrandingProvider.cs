using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace FilePermissionCheck.Web;

[Dependency(ReplaceServices = true)]
public class FilePermissionCheckBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "FilePermissionCheck";
}
