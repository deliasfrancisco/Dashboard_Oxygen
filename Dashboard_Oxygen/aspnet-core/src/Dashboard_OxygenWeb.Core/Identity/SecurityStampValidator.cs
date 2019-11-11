using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using Dashboard_OxygenWeb.Authorization.Roles;
using Dashboard_OxygenWeb.Authorization.Users;
using Dashboard_OxygenWeb.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace Dashboard_OxygenWeb.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory) 
            : base(options, signInManager, systemClock, loggerFactory)
        {
        }
    }
}
