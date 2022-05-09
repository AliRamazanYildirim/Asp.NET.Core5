using Microsoft.AspNetCore.Mvc;

namespace Asp.NET.Core5Projekt.Controllers
{
    public class UrsprünglichController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderTeil()
        {
            return PartialView();
        }
        public PartialViewResult NavbarTeil()
        {
            return PartialView();
        }
    }
}
