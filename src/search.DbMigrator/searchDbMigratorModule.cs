using search.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace search.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(searchEntityFrameworkCoreModule),
    typeof(searchApplicationContractsModule)
    )]
public class searchDbMigratorModule : AbpModule
{
}
