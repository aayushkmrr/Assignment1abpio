using Microsoft.Extensions.Localization;
using Assignment1.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Assignment1;

[Dependency(ReplaceServices = true)]
public class Assignment1BrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<Assignment1Resource> _localizer;

    public Assignment1BrandingProvider(IStringLocalizer<Assignment1Resource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
