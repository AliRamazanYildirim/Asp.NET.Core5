using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Core.Konkret
{
    public class BenutzerNachricht
    {
        [Key]
        public int NachrichtID { get; set; }
        public string Title { get; set; }
        public string Inhalt { get; set; }
        public DateTime Datum { get; set; }
        public bool Status { get; set; }
        public int BenutzerID { get; set; }
        public Benutzer Benutzers { get; set; }
    }
}
