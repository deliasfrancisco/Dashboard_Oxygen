using System.Collections.Generic;

namespace Dashboard_OxygenWeb.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
