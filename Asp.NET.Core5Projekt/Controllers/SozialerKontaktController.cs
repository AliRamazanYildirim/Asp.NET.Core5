using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.Controllers
{
    public class SozialerKontaktController : Controller
    {
        SozialerKontaktManager _sozialerKontaktManager = new SozialerKontaktManager(new EfSozialerKontaktDüo());
        public IActionResult Index()
        {
            var werte = _sozialerKontaktManager.TRufAlleDaten();
            return View(werte);
        }
        [HttpGet]
        public IActionResult InsertSozialerKontakt()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InsertSozialerKontakt(SozialerKontakt sozialerKontakt)
        {
            sozialerKontakt.Status = true;
            _sozialerKontaktManager.TInsert(sozialerKontakt);
            return RedirectToAction("Index");
        }
        
        public IActionResult LöschenSozialerKontakt(int ID)
        {
            var werte = _sozialerKontaktManager.TRufZurID(ID);
            _sozialerKontaktManager.TLöschen(werte);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AktualisierenSozialerKontakt(int ID)
        {
            var werte = _sozialerKontaktManager.TRufZurID(ID);
            return View(werte);
        }
        [HttpPost]
        public IActionResult AktualisierenSozialerKontakt(SozialerKontakt sozialerKontakt)
        {
            _sozialerKontaktManager.TAktualisieren(sozialerKontakt);
            return RedirectToAction("Index");
        }

    }
}
