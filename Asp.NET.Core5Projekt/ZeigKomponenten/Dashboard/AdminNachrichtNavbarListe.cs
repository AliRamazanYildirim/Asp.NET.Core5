using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Quelle.EF;
using System.Linq;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.Dashboard
{
    public class AdminNachrichtNavbarListe : ViewComponent
    {
        AnwenderNachrichtManager _anwenderNachrichtManager = new AnwenderNachrichtManager(new EfAnwenderNachrichtDüo());
        public IViewComponentResult Invoke()
        {
            string wert = "administrator@gmail.com";
            var werte = _anwenderNachrichtManager.RufListeEmpfaengerNachrichten(wert).OrderByDescending(x => x.AnwenderNachrichtID).Take(3).ToList();
            return View(werte);
        }
    }
}
