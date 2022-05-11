using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.Referenz
{
    public class ReferenzListe: ViewComponent
    {
        ReferenzManager referenzManager = new ReferenzManager(new EfReferenzDüo());
        public IViewComponentResult Invoke()
        {
            var werte = referenzManager.TRufAlleDaten();
            return View(werte);
        }
    }
}
