using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.Faehigkeit
{
    public class FaehigkeitListe : ViewComponent
    {
        FaehigkeitManager faehigkeitManager = new FaehigkeitManager(new EfFaehigkeitDüo());
        public IViewComponentResult Invoke()
        {
            var werte = faehigkeitManager.TRufAlleDaten();
            return View(werte);
        }
    }
}
