using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Core.Konkret
{
    public class Erfahrung
    {
        [Key]
        public int ErfahrungID { get; set; }
        public string Name { get; set; }
        public DateTime Datum  { get; set; }
        public string BildUrl { get; set; }
        public string Bezeichnung { get; set; }


    }
}
