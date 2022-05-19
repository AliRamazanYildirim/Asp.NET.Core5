using Microsoft.AspNetCore.Mvc;

namespace Asp.NET.Core5Projekt.ZeigKomponenten.Dashboard
{
    public class BesucherStatistiken : ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
