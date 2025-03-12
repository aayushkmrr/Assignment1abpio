using Xunit;

namespace Assignment1.EntityFrameworkCore;

[CollectionDefinition(Assignment1TestConsts.CollectionDefinitionName)]
public class Assignment1EntityFrameworkCoreCollection : ICollectionFixture<Assignment1EntityFrameworkCoreFixture>
{

}
