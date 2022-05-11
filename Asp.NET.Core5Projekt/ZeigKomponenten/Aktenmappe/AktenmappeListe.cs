using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.Aktenmappe
{
    public class AktenmappeListe:ViewComponent
    {
        AktenmappeManager aktenmappeManager = new AktenmappeManager(new EfAktenmappeDüo());
        public IViewComponentResult Invoke()
        {
            var werte = aktenmappeManager.TRufAlleDaten();
            return View(werte);
        }
    }
}
