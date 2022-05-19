using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.Areas.Benutzer.Controllers
{
    [Area("Benutzer")]
    [Authorize]
    public class BenutzerController : Controller
    {
        AktenmappeManager aktenmappeManager = new AktenmappeManager(new EfAktenmappeDüo());
        public IActionResult Index()
        {
            var werte = aktenmappeManager.TRufAlleDaten();
            return View(werte);
        }
    }
}
