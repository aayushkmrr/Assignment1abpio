using Volo.Abp.Modularity;

namespace Assignment1;

/* Inherit from this class for your domain layer tests. */
public abstract class Assignment1DomainTestBase<TStartupModule> : Assignment1TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
