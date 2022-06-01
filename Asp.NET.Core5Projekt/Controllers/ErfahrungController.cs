using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ErfahrungController : Controller
    {
        ErfahrungManager _erfahrungManager = new ErfahrungManager(new EfErfahrungDüo());
        public IActionResult Index()
        {
            ViewBag.w1 = "Erfahrungliste";
            ViewBag.w2 = "Erfahrungen";
            ViewBag.w3 = "Erfahrungliste";
            var werte = _erfahrungManager.TRufAlleDaten();
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
            _erfahrungManager.TInsert(e);
            return RedirectToAction("Index");
        }
        public IActionResult LöschenErfahrung(int ID)
        {
            var werte = _erfahrungManager.TRufZurID(ID);
            _erfahrungManager.TLöschen(werte);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult BearbeitenErfahrung(int ID)
        {
            ViewBag.w1 = "Erfahrungen Bearbeiten";
            ViewBag.w2 = "Erfahrungen";
            ViewBag.w3 = "Erfahrungen Bearbeiten";
            var werte = _erfahrungManager.TRufZurID(ID);
            return View(werte);
        }
        [HttpPost]
        public IActionResult BearbeitenErfahrung(Erfahrung e)
        {
            _erfahrungManager.TAktualisieren(e);
            return RedirectToAction("Index");
        }
    }
}
