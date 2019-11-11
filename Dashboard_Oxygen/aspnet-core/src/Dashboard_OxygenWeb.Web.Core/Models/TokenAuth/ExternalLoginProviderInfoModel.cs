using Abp.AutoMapper;
using Dashboard_OxygenWeb.Authentication.External;

namespace Dashboard_OxygenWeb.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
