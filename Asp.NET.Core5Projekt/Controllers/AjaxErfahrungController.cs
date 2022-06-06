using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.Controllers
{
    public class AjaxErfahrungController : Controller
    {
        ErfahrungManager _erfahrungManager = new ErfahrungManager(new EfErfahrungDüo());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ErfahrungAuflisten()
        {
            var werte = JsonConvert.SerializeObject(_erfahrungManager.TRufAlleDaten());
            return Json(werte);
        }
        [HttpPost]
        public IActionResult InsertErfahrung(Erfahrung erfahrung)
        {
            _erfahrungManager.TInsert(erfahrung);
            var werte = JsonConvert.SerializeObject(erfahrung);
            return Json(werte);
        }
        public IActionResult RufZurID(int ErfahrungID)
        {
            var wert = _erfahrungManager.TRufZurID(ErfahrungID);
            var werte = JsonConvert.SerializeObject(wert);
            return Json(werte);
        }
        public IActionResult LöschenErfahrung(int ID)
        {
            var wert = _erfahrungManager.TRufZurID(ID);
            _erfahrungManager.TLöschen(wert);
            return NoContent();
        }
        public IActionResult AktualisierenErfahrung(Erfahrung erfahrung)
        {
            var wert = _erfahrungManager.TRufZurID(erfahrung.ErfahrungID);
            _erfahrungManager.TAktualisieren(wert);
            var werte = JsonConvert.SerializeObject(erfahrung);
            return Json(werte);
        }
    }
}
