using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FilePermissionCheck.Data;

/* This is used if database provider does't define
 * IFilePermissionCheckDbSchemaMigrator implementation.
 */
public class NullFilePermissionCheckDbSchemaMigrator : IFilePermissionCheckDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
