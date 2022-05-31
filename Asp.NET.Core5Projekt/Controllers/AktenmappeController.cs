using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.ArbeitsEinheit.Validierung;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.EF;


namespace Asp.NET.Core5Projekt.Controllers
{
    public class AktenmappeController : Controller
    {
        AktenmappeManager aktenmappeManager = new AktenmappeManager(new EfAktenmappeDüo());
        public IActionResult Index()
        {
            ViewBag.w1 = "Aktenmappeliste";
            ViewBag.w2 = "Aktenmappen";
            ViewBag.w3 = "Aktenmappeliste";
            var werte = aktenmappeManager.TRufAlleDaten();
            return View(werte);
        }
        [HttpGet]
        public IActionResult InsertAktenmappe()
        {
            ViewBag.w1 = "Aktenmappeliste";
            ViewBag.w2 = "Aktenmappen";
            ViewBag.w3 = "Aktenmappeliste";
            return View();
        }
        [HttpPost]
        public IActionResult InsertAktenmappe(Aktenmappe a)
        {
            ViewBag.w1 = "Aktenmappeliste";
            ViewBag.w2 = "Aktenmappen";
            ViewBag.w3 = "Aktenmappeliste";
            AktenmappeValidator validations = new AktenmappeValidator();
            ValidationResult validationResult = validations.Validate(a);
            if(validationResult.IsValid)
            {
                aktenmappeManager.TInsert(a);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult LöschenAktenmappe(int ID)
        {
            var werte = aktenmappeManager.TRufZurID(ID);
            aktenmappeManager.TLöschen(werte);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult BearbeitenAktenmappe(int ID)
        {
            ViewBag.w1 = "Aktenmappeliste";
            ViewBag.w2 = "Aktenmappen";
            ViewBag.w3 = "Aktenmappeliste";
            var werte = aktenmappeManager.TRufZurID(ID);
            return View(werte);
        }
        [HttpPost]
        public IActionResult BearbeitenAktenmappe(Aktenmappe a)
        {
            AktenmappeValidator validations = new AktenmappeValidator();
            ValidationResult validationResult = validations.Validate(a);
            if(validationResult.IsValid)
            {
                aktenmappeManager.TAktualisieren(a);
                return RedirectToAction("Index");
            }
            
            else 
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
