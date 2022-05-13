using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.Controllers
{
    public class DienstController : Controller
    {
        DienstManager dienstManager = new DienstManager(new EfDienstDüo());
       
        public IActionResult Index()
        {
            ViewBag.w1 = "Dienst Bearbeiten";
            ViewBag.w2 = "Dienst";
            ViewBag.w3 = "Dienst Bearbeiten";
            var werte = dienstManager.TRufAlleDaten();
            return View(werte);
        }
        [HttpGet]
        public IActionResult InsertDienst()
        {
            ViewBag.w1 = "Dienst Hinzufügen";
            ViewBag.w2 = "Dienste";
            ViewBag.w3 = "Dienst Hinzufügen";
            return View();
        }
        [HttpPost]
        public IActionResult InsertDienst(Dienst d)
        {
            dienstManager.TInsert(d);
            return RedirectToAction("Index");
        }
        public IActionResult LöschenDienst(int ID)
        {
            var werte = dienstManager.TRufZurID(ID);
            dienstManager.TLöschen(werte);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult BearbeitenDienst(int ID)
        {
            ViewBag.w1 = "Dienst Bearbeiten";
            ViewBag.w2 = "Dienste";
            ViewBag.w3 = "Dienst Bearbeiten";
            var werte = dienstManager.TRufZurID(ID);
            return View("Index");
        }
        [HttpPost]
        public IActionResult BearbeitenDienst(Dienst d)
        {
            dienstManager.TAktualisieren(d);
            return RedirectToAction("Index");
        }
    }
}
