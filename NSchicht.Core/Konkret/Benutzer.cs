using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Core.Konkret
{
    public class Benutzer
    {
        [Key]
        public int BenutzerID { get; set; }
        public string Name { get; set; }
        public string Nachname { get; set; }
        public string BenutzerName { get; set; }
        public string Mail { get; set; }
        public string Passwort { get; set; }
        public string BildUrl { get; set; }
        public bool Status { get; set; }
        public List<BenutzerNachricht> BenutzerNachrichten { get; set; }
    }
}
