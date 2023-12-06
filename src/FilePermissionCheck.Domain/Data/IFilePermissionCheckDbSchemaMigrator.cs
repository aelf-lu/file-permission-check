using System.Threading.Tasks;

namespace FilePermissionCheck.Data;

public interface IFilePermissionCheckDbSchemaMigrator
{
    Task MigrateAsync();
}
