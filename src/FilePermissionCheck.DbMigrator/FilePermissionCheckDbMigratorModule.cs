using FilePermissionCheck.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace FilePermissionCheck.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FilePermissionCheckEntityFrameworkCoreModule),
    typeof(FilePermissionCheckApplicationContractsModule)
    )]
public class FilePermissionCheckDbMigratorModule : AbpModule
{
}
