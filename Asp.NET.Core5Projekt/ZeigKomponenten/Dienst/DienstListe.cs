using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.Views.Shared.Components.Dienst
{
    public class DienstListe:ViewComponent
    {
        DienstManager dienstManager = new DienstManager(new EfDienstDüo());
        public IViewComponentResult Invoke()
        {
            var werte = dienstManager.TRufAlleDaten();
            return View(werte);
        }
    }
}
