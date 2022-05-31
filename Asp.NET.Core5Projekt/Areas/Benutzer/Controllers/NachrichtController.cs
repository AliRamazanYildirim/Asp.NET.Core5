using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.EF;
using NSchicht.Quelle.Konkret;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NET.Core5Projekt.Areas.Benutzer.Controllers
{
    [Area("Benutzer")]
    [Route("Benutzer/Nachricht")]
    public class NachrichtController : Controller
    {
        AnwenderNachrichtManager _anwenderNachrichtManager = new AnwenderNachrichtManager(new EfAnwenderNachrichtDüo());
        private readonly UserManager<IdentityBenutzer> _userManager;

        public NachrichtController(UserManager<IdentityBenutzer> userManager)
        {
            _userManager = userManager;
        }
        [Route("")]
        [Route("EmpfaengerNachricht")]
        public async Task<IActionResult> EmpfaengerNachricht(string mail)
        {
            var benutzer = await _userManager.FindByNameAsync(User.Identity.Name);
            mail = benutzer.Email;
            var nachrichtListe = _anwenderNachrichtManager.RufListeEmpfaengerNachrichten(mail);

            return View(nachrichtListe);
        }
        [Route("")]
        [Route("AbsenderNachricht")]
        public async Task<IActionResult> AbsenderNachricht(string mail)
        {
            var benutzer = await _userManager.FindByNameAsync(User.Identity.Name);
            mail = benutzer.Email;
            var nachrichtListe = _anwenderNachrichtManager.RufListeAbsenderNachrichten(mail);

            return View(nachrichtListe);
        }
        [Route("EmpfaengerNachrichtDetails/{id}")]
        public IActionResult EmpfaengerNachrichtDetails(int ID)
        {
            AnwenderNachricht anwenderNachricht = _anwenderNachrichtManager.TRufZurID(ID);
            return View(anwenderNachricht);
        }
        [Route("AbsenderNachrichtDetails/{id}")]
        public IActionResult AbsenderNachrichtDetails(int ID)
        {
            AnwenderNachricht anwenderNachricht = _anwenderNachrichtManager.TRufZurID(ID);
            return View(anwenderNachricht);
        }
        [HttpGet]
        [Route("")]
        [Route("SendeNachricht")]
        public IActionResult SendeNachricht()
        {
            
            return View();
        }
        [HttpPost]
        [Route("")]
        [Route("SendeNachricht")]
        public async Task<IActionResult> SendeNachricht(AnwenderNachricht anwenderNachricht)
        {
            var benutzer = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = benutzer.Email;
            string name = benutzer.Name + " " + benutzer.NachName;
            anwenderNachricht.Datum = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            anwenderNachricht.Absender = mail;
            anwenderNachricht.AbsenderName=name;
            Kontext kontext = new Kontext();
            var benutzerinfos = kontext.Users.Where(x => x.Email == anwenderNachricht.Absender).Select(r => r.Name + " " + r.NachName).FirstOrDefault();
            anwenderNachricht.EmpfaengerName = benutzerinfos;
            _anwenderNachrichtManager.TInsert(anwenderNachricht);
            return RedirectToAction("AbsenderNachricht");
        }
    }
}
