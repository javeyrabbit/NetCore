using Volo.Abp.Modularity;

namespace search;

public abstract class searchApplicationTestBase<TStartupModule> : searchTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
