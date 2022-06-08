using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NET.Core5Projekt.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.w1 = "Dashboard Bearbeiten";
            ViewBag.w2 = "Dashboard";
            ViewBag.w3 = "Dashboard Bearbeiten";
            return View();
        }
    }
}
