using Asp.Net_Core_API.DÜO.ApiEinheit;
using Asp.Net_Core_API.DÜO.ApiKontext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Asp.Net_Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategorieController : ControllerBase
    {
        [HttpGet]
        public IActionResult KategorieListe()
        {
            using var apiKontext = new ApiKontext();
            return Ok(apiKontext.Kategorien.ToList());
        }

        [HttpGet("{ID}")]
        public IActionResult CategoryGet(int ID)
        {
            using var apiKontext = new ApiKontext();
            var wert = apiKontext.Kategorien.Find(ID);
            if (wert == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(wert);
            }
        }

        [HttpPost]
        public IActionResult InsertKategorie(Kategorie kategorie)
        {
            using var apiKontext = new ApiKontext();
            apiKontext.Add(kategorie);
            apiKontext.SaveChanges();
            return Created("", kategorie);
        }
        [HttpDelete]
        public IActionResult LöschenKategorie(int ID)
        {
            using var apiKontext = new ApiKontext();
            var wert = apiKontext.Kategorien.Find(ID);
            if (wert == null)
            {
                return NotFound();
            }
            else
            {
                apiKontext.Remove(wert);
                apiKontext.SaveChanges();
                return NoContent();
            }
        }
        [HttpPut]
        public IActionResult AktualisierenKategorie(Kategorie kategorie)
        {
            using var apiKontext = new ApiKontext();
            var wert = apiKontext.Find<Kategorie>(kategorie.KategorieID);
            if (wert == null)
            {
                return NotFound();
            }
            else
            {
                wert.KategorieName = kategorie.KategorieName;
                apiKontext.Update(wert);
                apiKontext.SaveChanges();
                return NoContent();
            }
        }
    }
}
