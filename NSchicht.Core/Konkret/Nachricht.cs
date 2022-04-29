using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Core.Konkret
{
    public class Nachricht
    {
        public int NachrichtID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Inhalt { get; set; }
        public DateTime Datum { get; set; }
        public bool Status { get; set; }
    }
}
