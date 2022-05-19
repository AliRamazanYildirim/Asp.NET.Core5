using Microsoft.AspNetCore.Mvc;
using NSchicht.Quelle.Konkret;
using System.Linq;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.Dashboard
{
    public class EigenschaftStatistiken : ViewComponent
    {
        Kontext kontext = new Kontext();
        public IViewComponentResult Invoke()
        {
            ViewBag.w1 = kontext.Faehigkeiten.Count();
            ViewBag.w2 = kontext.Nachrichten.Where(x=>x.Status==false).Count();
            ViewBag.w3 = kontext.Nachrichten.Where(x => x.Status == true).Count();
            ViewBag.w4 = kontext.Erfahrungen.Count();
            return View();
        }
    }
    
}
