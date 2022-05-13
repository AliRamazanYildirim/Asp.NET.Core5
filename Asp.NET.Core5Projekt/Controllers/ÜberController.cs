using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.Controllers
{
    public class ÜberController : Controller
    {
        ÜberManager überManager = new ÜberManager(new EfÜberDüo());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.w1 = "Über Bearbeiten";
            ViewBag.w2 = "Über";
            ViewBag.w3 = "Über Bearbeiten";
            var werte = überManager.TRufZurID(1);
            return View(werte);
        }

        [HttpPost]
        public IActionResult Index(Über ü)
        {
            überManager.TAktualisieren(ü);
            return RedirectToAction("Index", "Ursprünglich");
        }
    }
}
