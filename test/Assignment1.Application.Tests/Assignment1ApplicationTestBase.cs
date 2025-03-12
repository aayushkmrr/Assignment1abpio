using Volo.Abp.Modularity;

namespace Assignment1;

public abstract class Assignment1ApplicationTestBase<TStartupModule> : Assignment1TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
