using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.EF;
using System;

namespace Asp.NET.Core5Projekt.Controllers
{
    [AllowAnonymous]
    public class UrsprünglichController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderTeil()
        {
            return PartialView();
        }
        public PartialViewResult NavbarTeil()
        {
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult SendeNachrichten()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SendeNachrichten(Nachricht n)
        {
            NachrichtManager nachrichtManager = new NachrichtManager(new EfNachrichtDüo());
            n.Datum = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            n.Status = true;
            nachrichtManager.TInsert(n);
            return PartialView();
        }
    }
}
