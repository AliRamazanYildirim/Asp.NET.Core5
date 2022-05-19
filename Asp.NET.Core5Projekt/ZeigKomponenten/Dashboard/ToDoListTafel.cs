using Microsoft.AspNetCore.Mvc;
using NSchicht.ArbeitsEinheit.Konkret;
using NSchicht.Quelle.EF;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.Dashboard
{
    public class ToDoListTafel : ViewComponent
    {
        ToDoListManager _toDoListManager = new ToDoListManager(new EfToDoListDüo());
        public IViewComponentResult Invoke()
        {
            var werte = _toDoListManager.TRufAlleDaten();
            return View(werte);
        }
    }
}
