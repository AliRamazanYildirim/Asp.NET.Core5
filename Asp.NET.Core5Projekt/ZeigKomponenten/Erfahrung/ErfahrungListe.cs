using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.Erfahrung
{
    public class ErfahrungListe : ViewComponent
    {
       ErfahrungManager erfahrungManager= new ErfahrungManager(new EfErfahrungDüo());
        public IViewComponentResult Invoke()
        {
            var werte = erfahrungManager.TRufAlleDaten();
            return View(werte);
        }
    }
}
