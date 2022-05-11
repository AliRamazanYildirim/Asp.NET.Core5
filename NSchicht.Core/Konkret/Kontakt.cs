using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Core.Konkret
{
    public class Kontakt
    {
        [Key]
        public int KontaktID { get; set; }
        public string Title { get; set; }
        public string Bezeichnung { get; set; }
        public string Mail { get; set; }
        public string TelefonNummer { get; set; }
    }
}
