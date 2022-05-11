using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.Kontakt
{
    public class KontaktDetails:ViewComponent
    {
        KontaktManager kontaktManager = new KontaktManager(new EfKontaktDüo());
        public IViewComponentResult Invoke()
        {
            var werte = kontaktManager.TRufAlleDaten();
            return View(werte);
        }
    }
}
