using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.Controllers
{
    public class KontaktFusszeileController : Controller
    {
        KontaktManager _kontaktManager = new KontaktManager(new EfKontaktDüo());

        [HttpGet]
        public IActionResult Index()
        {
            var werte = _kontaktManager.TRufZurID(1);
            return View(werte);
        }
        [HttpPost]
        public IActionResult Index(Kontakt kontakt)
        {
            _kontaktManager.TAktualisieren(kontakt);
            return RedirectToAction("Index", "Ursprünglich");
        }
    }
}
