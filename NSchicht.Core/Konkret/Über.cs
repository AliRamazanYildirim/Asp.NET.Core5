using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Core.Konkret
{
    public class Über
    {
        [Key]
        public int ÜberID { get; set; }
        public string Title { get; set; }
        public string Bezeichnung { get; set; }
        public int Alter { get; set; }
        public string Mail { get; set; }
        public int TelefonNummer { get; set; }
        public string Adresse { get; set; }
        public string BildUrl { get; set; }


    }
}
