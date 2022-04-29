using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Core.Konkret
{
    public class Kontakt
    {
        public int KontaktID { get; set; }
        public string Title { get; set; }
        public string Bezeichnung { get; set; }
        public string Mail { get; set; }
        public int TelefonNummer { get; set; }
    }
}
