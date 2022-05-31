using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.EF;
using NSchicht.Quelle.Konkret;
using System;
using System.Linq;

namespace Asp.NET.Core5Projekt.Controllers
{
    public class AdminNachrichtController : Controller
    {
        AnwenderNachrichtManager _anwenderNachrichtManager = new AnwenderNachrichtManager(new EfAnwenderNachrichtDüo());
     
        public IActionResult EmpfaengerNachrichtListe()
        {
            string mail;
            mail = "administrator@gmail.com";
            var werte = _anwenderNachrichtManager.RufListeEmpfaengerNachrichten(mail);
            return View(werte);
        }
        public IActionResult AbsenderNachrichtListe()
        {
            string mail;
            mail = "administrator@gmail.com";
            var werte = _anwenderNachrichtManager.RufListeAbsenderNachrichten(mail);
            return View(werte);
        }
        public IActionResult AdminNachrichtDetails(int ID)
        {
            
            var werte = _anwenderNachrichtManager.TRufZurID(ID);
            return View(werte);
        }
        public IActionResult AdminNachrichtLöschen(int ID)
        {
            var werte = _anwenderNachrichtManager.TRufZurID(ID);
            _anwenderNachrichtManager.TLöschen(werte);
            return RedirectToAction("AbsenderNachrichtListe");
        }
        [HttpGet]
        public IActionResult AdminNachrichtSende()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminNachrichtSende(AnwenderNachricht anwenderNachricht)
        {
            anwenderNachricht.Absender = "administrator@gmail.com";
            anwenderNachricht.AbsenderName = "Admin";
            anwenderNachricht.Datum = DateTime.Parse(DateTime.Now.ToShortDateString());
            Kontext c = new Kontext();
            var benutzerinfos = c.Users.Where(x => x.Email == anwenderNachricht.Empfaenger).Select(r => r.Name + " " + r.NachName).FirstOrDefault();
            anwenderNachricht.EmpfaengerName = benutzerinfos;
            _anwenderNachrichtManager.TInsert(anwenderNachricht);
            return RedirectToAction("AbsenderNachrichtListe");
        }
    }
}
