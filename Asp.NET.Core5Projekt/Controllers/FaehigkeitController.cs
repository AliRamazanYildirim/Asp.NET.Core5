﻿using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.Controllers
{
    public class FaehigkeitController : Controller
    {
        FaehigkeitManager faehigkeitManager = new FaehigkeitManager(new EfFaehigkeitDüo());
        public IActionResult Index()
        {
            ViewBag.w1 = "Fähigkeitliste";
            ViewBag.w2 = "Fähigkeiten";
            ViewBag.w3 = "Fähigkeitliste";
            var werte = faehigkeitManager.TRufAlleDaten();
            return View(werte);
        }
        [HttpGet]
        public IActionResult InsertFaehigkeit()
        {
            ViewBag.w1 = "Fähigkeiten Hinzufügen";
            ViewBag.w2 = "Fähigkeiten";
            ViewBag.w3 = "Fähigkeiten Hinzufügen";
            return View();
        }
        [HttpPost]
        public IActionResult InsertFaehigkeit(Faehigkeit f)
        {
            faehigkeitManager.TInsert(f);
            return RedirectToAction("Index");
        }
        public IActionResult LöschenFaehigkeit(int ID)
        {
            var werte = faehigkeitManager.TRufZurID(ID);
            faehigkeitManager.TLöschen(werte);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult BearbeitenFaehigkeit(int ID)
        {
            ViewBag.w1 = "Fähigkeiten Bearbeiten";
            ViewBag.w2 = "Fähigkeiten";
            ViewBag.w3 = "Fähigkeiten Bearbeiten";
            var werte = faehigkeitManager.TRufZurID(ID);
            return View("Index");
        }
        [HttpPost]
        public IActionResult BearbeitenFaehigkeit(Faehigkeit f)
        {
            faehigkeitManager.TAktualisieren(f);
            return RedirectToAction("Index");
        }
    }
}