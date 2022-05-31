using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Asp.NET.Core5Projekt.Areas.Benutzer.Models
{
    public class BenutzerBearbeitenZeigModell
    {
        [Required(ErrorMessage = "Bitte geben Sie ihren Name ein")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bitte geben Sie ihren Nachname ein")]
        public string NachName { get; set; }
        [Required(ErrorMessage = "Bitte geben Sie die Bildurl ein")]
        public string BildUrl { get; set; }
        [Required(ErrorMessage = "Bitte laden Sie die Bild hoch")]
        public IFormFile Bild { get; set; }
        [Required(ErrorMessage = "Bitte geben Sie ihr Passwort ein")]
        public string Passwort { get; set; }
        [Required(ErrorMessage = "Bitte geben Sie ihr Passwort erneut ein")]
        [Compare("Passwort", ErrorMessage = "Die eingegebenen Passwörter stimmen nicht überein")]
        public string KonfirmierePasswort { get; set; }
    }
}
