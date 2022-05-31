using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.Konkret;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Asp.NET.Core5Projekt.Areas.Benutzer.Controllers
{
    [Area("Benutzer")]
    public class BenutzerDashboardController : Controller
    {
        private readonly UserManager<IdentityBenutzer> _userManager;

        public BenutzerDashboardController(UserManager<IdentityBenutzer> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var benutzer = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.w = benutzer.Name + " " + benutzer.NachName;

            //Weather Api
            string wetterapi = "2d59124e42f89f28c99a311b3a1d14a7";
            string verbindung = "https://api.openweathermap.org/data/2.5/weather?q=dusseldorf&mode=xml&lang=de&units=metric&appid=" + wetterapi;
            XDocument xDocument = XDocument.Load(verbindung);
            ViewBag.w5 = xDocument.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //Statistiken
            Kontext kontext = new Kontext();
            ViewBag.w1 = kontext.AnwenderNachrichten.Where(x=>x.Empfaenger==benutzer.Email).Count();
            ViewBag.w2 = kontext.AnwenderNachrichten.Count();
            ViewBag.w3 = kontext.Users.Count();
            ViewBag.w4 = kontext.Aktenmappen.Count();

            return View();
        }
    }
}
