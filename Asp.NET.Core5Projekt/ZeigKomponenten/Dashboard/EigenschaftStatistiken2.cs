using Microsoft.AspNetCore.Mvc;
using NSchicht.Quelle.Konkret;
using System.Linq;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.Dashboard
{
    public class EigenschaftStatistiken2 : ViewComponent
    {
        Kontext kontext = new Kontext();
        public IViewComponentResult Invoke()
        {
            ViewBag.w1 = kontext.Aktenmappen.Count();
            ViewBag.w2 = kontext.Nachrichten.Count();
            ViewBag.w3 = kontext.Dienste.Count();
            return View();
        }
    }
}
