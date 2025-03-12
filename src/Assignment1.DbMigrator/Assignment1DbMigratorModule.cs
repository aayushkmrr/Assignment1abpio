using Assignment1.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Assignment1.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Assignment1EntityFrameworkCoreModule),
    typeof(Assignment1ApplicationContractsModule)
)]
public class Assignment1DbMigratorModule : AbpModule
{
}
