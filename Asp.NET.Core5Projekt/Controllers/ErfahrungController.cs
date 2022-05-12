using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.Controllers
{
    public class ErfahrungController : Controller
    {
        ErfahrungManager erfahrungManager = new ErfahrungManager(new EfErfahrungDüo());
        public IActionResult Index()
        {
            ViewBag.w1 = "Erfahrungliste";
            ViewBag.w2 = "Erfahrungen";
            ViewBag.w3 = "Erfahrungliste";
            var werte = erfahrungManager.TRufAlleDaten();
            return View(werte);
        }
        [HttpGet]
        public IActionResult InsertErfahrung()
        {
            ViewBag.w1 = "Erfahrungen Hinzufügen";
            ViewBag.w2 = "Erfahrungen";
            ViewBag.w3 = "Erfahrungen Hinzufügen";
            return View();
        }
        [HttpPost]
        public IActionResult InsertErfahrung(Erfahrung e)
        {
            erfahrungManager.TInsert(e);
            return RedirectToAction("Index");
        }
        public IActionResult LöschenErfahrung(int ID)
        {
            var werte = erfahrungManager.TRufZurID(ID);
            erfahrungManager.TLöschen(werte);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult BearbeitenErfahrung(int ID)
        {
            ViewBag.w1 = "Erfahrungen Bearbeiten";
            ViewBag.w2 = "Erfahrungen";
            ViewBag.w3 = "Erfahrungen Bearbeiten";
            var werte = erfahrungManager.TRufZurID(ID);
            return View("Index");
        }
        [HttpPost]
        public IActionResult BearbeitenErfahrung(Erfahrung e)
        {
            erfahrungManager.TAktualisieren(e);
            return RedirectToAction("Index");
        }
    }
}
