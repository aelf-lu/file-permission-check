using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FilePermissionCheck.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class FilePermissionCheckDbContextFactory : IDesignTimeDbContextFactory<FilePermissionCheckDbContext>
{
    public FilePermissionCheckDbContext CreateDbContext(string[] args)
    {
        FilePermissionCheckEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<FilePermissionCheckDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new FilePermissionCheckDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../FilePermissionCheck.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
