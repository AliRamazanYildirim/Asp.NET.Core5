using Microsoft.AspNetCore.Mvc;

namespace Asp.NET.Core5Projekt.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
