using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.Dashboard
{
    public class ProjektListe : ViewComponent
    {
        AktenmappeManager _aktenmappeManager = new AktenmappeManager(new EfAktenmappeDüo());
        public IViewComponentResult Invoke()
        {
            //ViewBag.w1 = _aktenmappeManager.Aktenmappen.Count();
            //ViewBag.w2 = _aktenmappeManager.Nachrichten.Count();
            //ViewBag.w3 = _aktenmappeManager.Dienste.Count();
            var werte = _aktenmappeManager.TRufAlleDaten();
            return View(werte);
        }
    }
}
