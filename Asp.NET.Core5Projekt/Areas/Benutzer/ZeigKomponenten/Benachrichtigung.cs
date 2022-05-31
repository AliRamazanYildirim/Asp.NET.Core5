using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Quelle.EF;
using System.Linq;

namespace Asp.NET.Core5Projekt.Areas.Benutzer.ZeigKomponenten
{
    public class Benachrichtigung:ViewComponent
    {
        ToDoListManager toDoListManager = new ToDoListManager(new EfToDoListDüo());
        public IViewComponentResult Invoke()
        {
            var werte = toDoListManager.TRufAlleDaten();
            return View(werte);
        }
    }
}
