using Volo.Abp.Modularity;

namespace Assignment1;

[DependsOn(
    typeof(Assignment1DomainModule),
    typeof(Assignment1TestBaseModule)
)]
public class Assignment1DomainTestModule : AbpModule
{

}
