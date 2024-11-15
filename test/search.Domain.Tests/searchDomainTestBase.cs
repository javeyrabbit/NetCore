using Volo.Abp.Modularity;

namespace search;

/* Inherit from this class for your domain layer tests. */
public abstract class searchDomainTestBase<TStartupModule> : searchTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
