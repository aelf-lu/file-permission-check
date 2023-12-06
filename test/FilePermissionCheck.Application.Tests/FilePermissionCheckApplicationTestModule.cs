using Volo.Abp.Modularity;

namespace FilePermissionCheck;

[DependsOn(
    typeof(FilePermissionCheckApplicationModule),
    typeof(FilePermissionCheckDomainTestModule)
    )]
public class FilePermissionCheckApplicationTestModule : AbpModule
{

}
