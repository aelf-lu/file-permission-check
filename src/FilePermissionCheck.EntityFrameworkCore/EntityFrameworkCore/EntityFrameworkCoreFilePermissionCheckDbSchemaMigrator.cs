using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FilePermissionCheck.Data;
using Volo.Abp.DependencyInjection;

namespace FilePermissionCheck.EntityFrameworkCore;

public class EntityFrameworkCoreFilePermissionCheckDbSchemaMigrator
    : IFilePermissionCheckDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreFilePermissionCheckDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the FilePermissionCheckDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<FilePermissionCheckDbContext>()
            .Database
            .MigrateAsync();
    }
}
