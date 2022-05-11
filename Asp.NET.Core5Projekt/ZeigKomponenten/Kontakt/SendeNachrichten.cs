using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.EF;
using System;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.Kontakt
{
    public class SendeNachrichten:ViewComponent
    {
        NachrichtManager nachrichtManager = new NachrichtManager(new EfNachrichtDüo());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Nachricht n)
        //{
        //    n.Datum = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    n.Status = true;
        //    nachrichtManager.TInsert(n);
        //    return View();
        //}
    }
}
