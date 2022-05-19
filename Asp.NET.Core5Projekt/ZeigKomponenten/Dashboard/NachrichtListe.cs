using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.Dashboard
{
    public class NachrichtListe : ViewComponent
    {
        BenutzerNachrichtManager _benutzerNachrichtManager = new BenutzerNachrichtManager(new EfBenutzerNachrichtDüo());
        public IViewComponentResult Invoke()
        {
            var werte = _benutzerNachrichtManager.RufBenutzerNachrichtMitBenutzerDienst();
            return View(werte);
        }
    }
}
