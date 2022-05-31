using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.SozialerKontakt
{
    public class SozialerKontaktListe:ViewComponent
    {
        SozialerKontaktManager _sozialerKontaktManager=new SozialerKontaktManager(new EfSozialerKontaktDüo());
        public IViewComponentResult Invoke()
        {
            var werte = _sozialerKontaktManager.TRufAlleDaten();
            return View(werte);
        }
    }
}
