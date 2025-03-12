using Assignment1.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Assignment1.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Assignment1Controller : AbpControllerBase
{
    protected Assignment1Controller()
    {
        LocalizationResource = typeof(Assignment1Resource);
    }
}
