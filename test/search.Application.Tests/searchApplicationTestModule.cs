using Volo.Abp.Modularity;

namespace search;

[DependsOn(
    typeof(searchApplicationModule),
    typeof(searchDomainTestModule)
)]
public class searchApplicationTestModule : AbpModule
{

}
