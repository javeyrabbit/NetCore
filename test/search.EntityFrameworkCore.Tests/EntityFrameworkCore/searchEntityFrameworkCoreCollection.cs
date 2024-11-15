using Xunit;

namespace search.EntityFrameworkCore;

[CollectionDefinition(searchTestConsts.CollectionDefinitionName)]
public class searchEntityFrameworkCoreCollection : ICollectionFixture<searchEntityFrameworkCoreFixture>
{

}
