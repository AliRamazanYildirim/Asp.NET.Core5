using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Core.Konkret
{
    public class AnwenderNachricht
    {
        [Key]
        public int AnwenderNachrichtID { get; set; }
        public string Absender { get; set; }
        public string Empfaenger { get; set; }
        public string AbsenderName { get; set; }
        public string EmpfaengerName { get; set; }
        public string Gegenstand { get; set; }
        public string Inhalt { get; set; }
        public DateTime Datum { get; set; }


    }
}
