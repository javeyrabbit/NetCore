using search.Samples;
using Xunit;

namespace search.EntityFrameworkCore.Domains;

[Collection(searchTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<searchEntityFrameworkCoreTestModule>
{

}
