using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Core.Konkret
{
    public class Aktenmappe
    {
        [Key]
        public int PortfolioID { get; set; }
        public string Name { get; set; }
        public string BildUrl { get; set; }
        public string ProjektUrlBild { get; set; }
        public string ProjektUrl { get; set; }
        public string Projekt { get; set; }
        public int Preis { get; set; }
        public bool Status { get; set; }
        public string ProjektBild1 { get; set; }
        public string ProjektBild2 { get; set; }
        public string ProjektBild3 { get; set; }
        public string ProjektBild4 { get; set; }
        public int Proportion { get; set; }



    }
}
