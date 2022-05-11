using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.Über
{
    public class ÜberListe:ViewComponent
    {
        ÜberManager überManager = new ÜberManager(new EfÜberDüo());
        public IViewComponentResult Invoke()
        {
            var werte = überManager.TRufAlleDaten();
            return View(werte);
        }
    }
}
