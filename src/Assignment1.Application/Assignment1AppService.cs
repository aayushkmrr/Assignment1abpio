using Assignment1.Localization;
using Volo.Abp.Application.Services;

namespace Assignment1;

/* Inherit your application services from this class.
 */
public abstract class Assignment1AppService : ApplicationService
{
    protected Assignment1AppService()
    {
        LocalizationResource = typeof(Assignment1Resource);
    }
}
