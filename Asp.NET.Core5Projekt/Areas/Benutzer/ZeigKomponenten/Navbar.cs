using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NSchicht.Core.Konkret;
using System.Threading.Tasks;

namespace Asp.NET.Core5Projekt.Areas.Benutzer.ZeigKomponenten
{
    public class Navbar : ViewComponent
    {
        private readonly UserManager<IdentityBenutzer> _userManager;

        public Navbar(UserManager<IdentityBenutzer> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var benutzer = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.w = benutzer.BildUrl;
            return View(benutzer);
        }
    }
}
