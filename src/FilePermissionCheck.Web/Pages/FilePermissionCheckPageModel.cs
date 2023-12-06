using FilePermissionCheck.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace FilePermissionCheck.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class FilePermissionCheckPageModel : AbpPageModel
{
    protected FilePermissionCheckPageModel()
    {
        LocalizationResourceType = typeof(FilePermissionCheckResource);
    }
}
