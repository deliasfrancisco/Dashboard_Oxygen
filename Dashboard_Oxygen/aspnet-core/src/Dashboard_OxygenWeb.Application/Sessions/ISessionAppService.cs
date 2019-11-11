using System.Threading.Tasks;
using Abp.Application.Services;
using Dashboard_OxygenWeb.Sessions.Dto;

namespace Dashboard_OxygenWeb.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
