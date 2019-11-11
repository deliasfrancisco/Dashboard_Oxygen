using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Dashboard_OxygenWeb.Controllers
{
    public abstract class Dashboard_OxygenWebControllerBase: AbpController
    {
        protected Dashboard_OxygenWebControllerBase()
        {
            LocalizationSourceName = Dashboard_OxygenWebConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
