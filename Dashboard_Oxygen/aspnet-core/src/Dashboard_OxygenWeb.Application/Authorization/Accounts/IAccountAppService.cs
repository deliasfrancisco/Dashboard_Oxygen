﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Dashboard_OxygenWeb.Authorization.Accounts.Dto;

namespace Dashboard_OxygenWeb.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
