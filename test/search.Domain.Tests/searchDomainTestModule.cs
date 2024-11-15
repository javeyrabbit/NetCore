using Volo.Abp.Modularity;

namespace search;

[DependsOn(
    typeof(searchDomainModule),
    typeof(searchTestBaseModule)
)]
public class searchDomainTestModule : AbpModule
{

}
