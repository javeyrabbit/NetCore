using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace search.Data;

/* This is used if database provider does't define
 * IsearchDbSchemaMigrator implementation.
 */
public class NullsearchDbSchemaMigrator : IsearchDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
