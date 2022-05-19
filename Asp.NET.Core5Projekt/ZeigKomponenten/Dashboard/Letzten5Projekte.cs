using Microsoft.AspNetCore.Mvc;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.Dashboard
{
    public class Letzten5Projekte : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
