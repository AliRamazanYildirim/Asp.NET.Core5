using Microsoft.AspNetCore.Mvc;

namespace Asp.NET.Core5Projekt.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult TeilSeitenLeiste()
        {
            return PartialView();
        }
        public PartialViewResult TeilFusszeile()
        {
            return PartialView();
        }
        public PartialViewResult TeilNavbar()
        {
            return PartialView();
        }
        public PartialViewResult TeilHeader()
        {
            return PartialView();
        }
        public PartialViewResult TeilScript()
        {
            return PartialView();
        }
        public PartialViewResult TeilNavigation()
        {
            return PartialView();
        }
    }
}
