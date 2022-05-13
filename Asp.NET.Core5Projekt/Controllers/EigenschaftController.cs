using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.Controllers
{
    public class EigenschaftController : Controller
    {
        EigenschaftManager eigenschaftManager = new EigenschaftManager(new EfEigenschaftDüo());
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.w1 = "Eigenschaft Bearbeiten";
            ViewBag.w2 = "Eigenschaft";
            ViewBag.w3 = "Eigenschaft Bearbeiten";
            var werte = eigenschaftManager.TRufZurID(1);
            return View(werte);
        }
        
        [HttpPost]
        public IActionResult Index(Eigenschaft e)
        {
            eigenschaftManager.TAktualisieren(e);
            return RedirectToAction("Index", "Ursprünglich");
        }
    }
}
