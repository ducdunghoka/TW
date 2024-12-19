using Microsoft.AspNetCore.Mvc;
using TW.DATA;

namespace TW.Controllers
{
    public abstract class BaseController<T> : Controller where T : BaseController<T>
    {
        private GeneralContext db;
        protected GeneralContext _db => db ??= HttpContext?.RequestServices.GetService<GeneralContext>();
    }
}
