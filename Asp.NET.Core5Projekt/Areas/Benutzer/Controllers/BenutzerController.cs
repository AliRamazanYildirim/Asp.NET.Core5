using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.Areas.Benutzer.Controllers
{
    [Area("Benutzer")]
    [Authorize]
    public class BenutzerController : Controller
    {
        ToDoListManager toDoListManager = new ToDoListManager(new EfToDoListDüo());
        public IActionResult Index()
        {
            var werte = toDoListManager.TRufAlleDaten();
            return View(werte);
        }
        [HttpGet]
        public IActionResult ToDoListEinzelheiten(int ID)
        {
            ToDoList toDoList = toDoListManager.TRufZurID(ID);
            return View(toDoList);
        }
    }
}
