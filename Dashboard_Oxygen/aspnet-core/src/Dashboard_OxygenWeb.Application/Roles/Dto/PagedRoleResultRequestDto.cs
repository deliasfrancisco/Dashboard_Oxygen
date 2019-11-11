using Abp.Application.Services.Dto;

namespace Dashboard_OxygenWeb.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

