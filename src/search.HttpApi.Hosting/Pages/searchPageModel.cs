using search.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace search.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class searchPageModel : AbpPageModel
{
    protected searchPageModel()
    {
        LocalizationResourceType = typeof(searchResource);
    }
}
