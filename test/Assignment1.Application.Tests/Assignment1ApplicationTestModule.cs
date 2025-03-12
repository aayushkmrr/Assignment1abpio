using Volo.Abp.Modularity;

namespace Assignment1;

[DependsOn(
    typeof(Assignment1ApplicationModule),
    typeof(Assignment1DomainTestModule)
)]
public class Assignment1ApplicationTestModule : AbpModule
{

}
