using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.Controllers
{
    public class AdminKontaktController : Controller
    {
        NachrichtManager _nachrichtManager = new NachrichtManager(new EfNachrichtDüo());
        public IActionResult Index()
        {
            var werte = _nachrichtManager.TRufAlleDaten();
            return View(werte);
        }
        public IActionResult LöschenKontakt(int ID)
        {
            var werte = _nachrichtManager.TRufZurID(ID);
            _nachrichtManager.TLöschen(werte);
            return RedirectToAction("Index");
        }
        public IActionResult KontaktDetails(int ID)
        {
            var werte = _nachrichtManager.TRufZurID(ID);

            return View(werte);
        }
    }
}
