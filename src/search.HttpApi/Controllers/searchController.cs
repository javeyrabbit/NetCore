using search.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace search.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class searchController : AbpControllerBase
{
    protected searchController()
    {
        LocalizationResource = typeof(searchResource);
    }
}
