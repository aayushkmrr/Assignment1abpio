using Assignment1.Samples;
using Xunit;

namespace Assignment1.EntityFrameworkCore.Domains;

[Collection(Assignment1TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<Assignment1EntityFrameworkCoreTestModule>
{

}
