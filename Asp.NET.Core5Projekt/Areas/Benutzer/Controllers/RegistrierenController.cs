using Asp.NET.Core5Projekt.Areas.Benutzer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NSchicht.Core.Konkret;
using System.Threading.Tasks;

namespace Asp.NET.Core5Projekt.Areas.Benutzer.Controllers
{
    [AllowAnonymous]
    [Area("Benutzer")]
    [Route("Benutzer/[controller]/[action]")]
    public class RegistrierenController : Controller
    {
        private readonly UserManager<IdentityBenutzer> _userManager;

        public RegistrierenController(UserManager<IdentityBenutzer> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new BenutzerRegistrierenZeigModell());
        }
        [HttpPost]
        public async Task<IActionResult> Index(BenutzerRegistrierenZeigModell benutzerRegistrierenZeigModell)
        {
            
                IdentityBenutzer identityBenutzer = new IdentityBenutzer()
                {
                    Name = benutzerRegistrierenZeigModell.Name,
                    NachName = benutzerRegistrierenZeigModell.NachName,
                    Email = benutzerRegistrierenZeigModell.Mail,
                    UserName = benutzerRegistrierenZeigModell.BenutzerName,
                    BildUrl = benutzerRegistrierenZeigModell.BildUrl
                };
                if(benutzerRegistrierenZeigModell.Passwort==benutzerRegistrierenZeigModell.KonfirmierePasswort)
                {
                    var resultat = await _userManager.CreateAsync(identityBenutzer, benutzerRegistrierenZeigModell.Passwort);
                if(resultat.Succeeded)
                {
                    return RedirectToAction("Index", "Anmeldung");
                }
                else
                {
                    foreach (var item in resultat.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                }
                
            
            return View(benutzerRegistrierenZeigModell);
        }
    }
}
