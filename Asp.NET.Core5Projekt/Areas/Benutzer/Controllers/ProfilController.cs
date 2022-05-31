using Asp.NET.Core5Projekt.Areas.Benutzer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NSchicht.Core.Konkret;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Asp.NET.Core5Projekt.Areas.Benutzer.Controllers
{
    [Area("Benutzer")]
    [Route("Benutzer/[controller]/[action]")]
    public class ProfilController : Controller
    {
        private readonly UserManager<IdentityBenutzer> _userManager;

        public ProfilController(UserManager<IdentityBenutzer> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var benutzer = await _userManager.FindByNameAsync(User.Identity.Name);
            BenutzerBearbeitenZeigModell modell = new BenutzerBearbeitenZeigModell();
            modell.Name= benutzer.Name;
            modell.NachName= benutzer.NachName;
            modell.BildUrl= benutzer.BildUrl;
            return View(modell);
        }
        [HttpPost]
        public async Task<IActionResult> Index(BenutzerBearbeitenZeigModell benutzerBearbeitenZeigModell)
        {
            var benutzer = await _userManager.FindByNameAsync(User.Identity.Name);
            if(benutzerBearbeitenZeigModell!=null)
            {
                var resource = Directory.GetCurrentDirectory();
                var erweiterung = Path.GetExtension(benutzerBearbeitenZeigModell.Bild.FileName);
                var bildname = Guid.NewGuid() + erweiterung;
                var sichererort = resource + "/wwwroot/benutzerbild/" + bildname;
                var strom = new FileStream(sichererort, FileMode.Create);
                await benutzerBearbeitenZeigModell.Bild.CopyToAsync(strom);
                benutzer.BildUrl = bildname;

            }
            benutzer.Name = benutzerBearbeitenZeigModell.Name;
            benutzer.NachName = benutzerBearbeitenZeigModell.NachName;
            benutzer.PasswordHash = _userManager.PasswordHasher.HashPassword(benutzer, benutzerBearbeitenZeigModell.Passwort);
            var resultat = await _userManager.UpdateAsync(benutzer);
            if(resultat.Succeeded)
            {
                return RedirectToAction("Index", "Anmeldung");
            }
            return View();
        }
    }
}
