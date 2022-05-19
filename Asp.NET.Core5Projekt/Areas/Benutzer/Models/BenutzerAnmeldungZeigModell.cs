using System.ComponentModel.DataAnnotations;

namespace Asp.NET.Core5Projekt.Areas.Benutzer.Models
{
    public class BenutzerAnmeldungZeigModell
    {
        [Display(Name ="Benutzername")]
        [Required(ErrorMessage = "Bitte geben Sie ihren Benutzernamen ein")]
        public string BenutzerName { get; set; }
        [Display(Name = "Passwort")]
        [Required(ErrorMessage = "Bitte geben Sie ihr Passwort ein")]
        public string Passwort { get; set; }
        
    }
}
