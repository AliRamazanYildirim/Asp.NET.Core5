using System.ComponentModel.DataAnnotations;

namespace Asp.Net_Core_API.DÜO.ApiEinheit
{
    public class Kategorie
    {
        [Key]
        public int KategorieID { get; set; }
        public string KategorieName { get; set; }
    }
}
