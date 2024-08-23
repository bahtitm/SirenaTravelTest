using Microsoft.AspNetCore.Mvc;
using SirenaTravelTest.Services;

namespace SirenaTravelTest.Controllers
{
    public class BaseController : ControllerBase
    {

        protected HttpServices httpServices => HttpContext.RequestServices.GetService<HttpServices>();
        protected ILogger logger => HttpContext.RequestServices.GetService<ILogger<BaseController>>();
    }
}
