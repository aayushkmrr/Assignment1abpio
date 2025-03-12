using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.Account;
using Volo.Abp.Identity;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;
using Volo.Abp.Data;
using Volo.Abp;
using Assignment1.seed;

namespace Assignment1;

[DependsOn(
    typeof(Assignment1DomainModule),
    typeof(Assignment1ApplicationContractsModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpAccountApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
public class Assignment1ApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<Assignment1ApplicationModule>();

        });

         public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        // Seed data after the application starts
        var dataSeeder = context.ServiceProvider.GetRequiredService<MyDataSeeder>();
        dataSeeder.SeedAsync().Wait();  // Ensure the seeding happens synchronously at startup
    }
}
}



