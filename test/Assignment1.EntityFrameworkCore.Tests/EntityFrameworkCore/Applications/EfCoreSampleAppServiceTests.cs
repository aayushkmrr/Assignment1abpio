using Assignment1.Samples;
using Xunit;

namespace Assignment1.EntityFrameworkCore.Applications;

[Collection(Assignment1TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<Assignment1EntityFrameworkCoreTestModule>
{

}
