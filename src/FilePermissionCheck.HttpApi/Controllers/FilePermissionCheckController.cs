using FilePermissionCheck.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FilePermissionCheck.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class FilePermissionCheckController : AbpControllerBase
{
    protected FilePermissionCheckController()
    {
        LocalizationResource = typeof(FilePermissionCheckResource);
    }
}
