using Microsoft.AspNetCore.Mvc;

namespace Asp.NET.Core5Projekt.Controllers
{
    public class ErrorSeitenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error404()
        {
            return View();
        }
    }
}
