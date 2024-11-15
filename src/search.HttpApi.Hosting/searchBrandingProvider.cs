using Microsoft.Extensions.Localization;
using search.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace search.Web;

[Dependency(ReplaceServices = true)]
public class searchBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<searchResource> _localizer;

    public searchBrandingProvider(IStringLocalizer<searchResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
