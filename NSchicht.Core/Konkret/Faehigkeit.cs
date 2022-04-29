using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Core.Konkret
{
    public class Faehigkeit
    {
        [Key]
        public int FaehigkeitID { get; set; }
        public string Title { get; set; }
        public string Wert { get; set; }

    }
}
