using System;
using System.Collections.Generic;
using System.Text;
using FilePermissionCheck.Localization;
using Volo.Abp.Application.Services;

namespace FilePermissionCheck;

/* Inherit your application services from this class.
 */
public abstract class FilePermissionCheckAppService : ApplicationService
{
    protected FilePermissionCheckAppService()
    {
        LocalizationResource = typeof(FilePermissionCheckResource);
    }
}
