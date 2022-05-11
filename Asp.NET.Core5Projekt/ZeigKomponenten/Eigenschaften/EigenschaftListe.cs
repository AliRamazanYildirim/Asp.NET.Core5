using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.Eigenschaften
{
    public class EigenschaftListe:ViewComponent
    {
        EigenschaftManager eigenschaftManager = new EigenschaftManager(new EfEigenschaftDüo());
        public IViewComponentResult Invoke()
        {
            var werte = eigenschaftManager.TRufAlleDaten();
            return View(werte);
        }
    }
}
