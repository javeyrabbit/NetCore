using search.Samples;
using Xunit;

namespace search.EntityFrameworkCore.Applications;

[Collection(searchTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<searchEntityFrameworkCoreTestModule>
{

}
