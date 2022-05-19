using Asp.NET.Core5Projekt.Areas.Benutzer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NSchicht.Core.Konkret;
using System.Threading.Tasks;

namespace Asp.NET.Core5Projekt.Areas.Benutzer.Controllers
{
    [Area("Benutzer")]
    public class AnmeldungController : Controller
    {
        private readonly SignInManager<IdentityBenutzer> _signInManager;

        public AnmeldungController(SignInManager<IdentityBenutzer> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(BenutzerAnmeldungZeigModell benutzerAnmeldungZeigModell)
        {
            if(ModelState.IsValid)
            {
                var resultat = await _signInManager.PasswordSignInAsync(benutzerAnmeldungZeigModell.BenutzerName, benutzerAnmeldungZeigModell.Passwort, true, true);
                if(resultat.Succeeded)
                {
                    return RedirectToAction("Index", "Ursprünglich");
                }
                else
                {
                    ModelState.AddModelError("", "Sie haben einen falschen Benutzernamen und ein falsches Passwort eingegeben.");

                }
            }
            return View();
        }
    }
}
