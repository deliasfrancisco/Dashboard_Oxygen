using Microsoft.AspNetCore.Antiforgery;
using Dashboard_OxygenWeb.Controllers;

namespace Dashboard_OxygenWeb.Web.Host.Controllers
{
    public class AntiForgeryController : Dashboard_OxygenWebControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
