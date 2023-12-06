using FilePermissionCheck.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace FilePermissionCheck;

[DependsOn(
    typeof(FilePermissionCheckEntityFrameworkCoreTestModule)
    )]
public class FilePermissionCheckDomainTestModule : AbpModule
{

}
