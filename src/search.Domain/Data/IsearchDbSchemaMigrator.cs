using System.Threading.Tasks;

namespace search.Data;

public interface IsearchDbSchemaMigrator
{
    Task MigrateAsync();
}
