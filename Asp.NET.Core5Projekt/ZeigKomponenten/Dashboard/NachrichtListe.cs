using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.Dashboard
{
    public class NachrichtListe : ViewComponent
    {
        NachrichtManager _nachrichtManager = new NachrichtManager(new EfNachrichtDüo());
        public IViewComponentResult Invoke()
        {
            //154.Lexion
            var werte = _nachrichtManager.TRufAlleDaten();
            return View(werte);
        }
    }
}
