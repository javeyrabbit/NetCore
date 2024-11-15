using System;
using System.Collections.Generic;
using System.Text;
using search.Localization;
using Volo.Abp.Application.Services;

namespace search;

/* Inherit your application services from this class.
 */
public abstract class searchAppService : ApplicationService
{
    protected searchAppService()
    {
        LocalizationResource = typeof(searchResource);
    }
}
