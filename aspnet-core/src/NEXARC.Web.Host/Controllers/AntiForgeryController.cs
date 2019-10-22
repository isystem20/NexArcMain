using Microsoft.AspNetCore.Antiforgery;
using NEXARC.Controllers;

namespace NEXARC.Web.Host.Controllers
{
    public class AntiForgeryController : NEXARCControllerBase
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
