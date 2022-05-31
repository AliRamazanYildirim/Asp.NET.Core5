using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.Controllers
{
    public class ReferenzController : Controller
    {

        ReferenzManager _referenzManager = new ReferenzManager(new EfReferenzDüo());
        public IActionResult Index()
        {
            var values = _referenzManager.TRufAlleDaten();
            return View(values);
        }

        [HttpGet]
        public IActionResult InsertReferenz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertReferenz(Referenz referenz)
        {
            _referenzManager.TInsert(referenz);
            return RedirectToAction("Index");
        }
        public IActionResult LöschenReferenz(int ID)
        {
            var werte = _referenzManager.TRufZurID(ID);
            _referenzManager.TLöschen(werte);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult BearbeitenReferenz(int ID)
        {
            var werte = _referenzManager.TRufZurID(ID);
            return View(werte);
        }
        [HttpPost]
        public IActionResult BearbeitenReferenz(Referenz referenz)
        {
            _referenzManager.TAktualisieren(referenz);
            return RedirectToAction("Index");
        }
    }
}
