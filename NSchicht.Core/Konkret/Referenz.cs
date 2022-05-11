using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Core.Konkret
{
    public class Referenz
    {
        [Key]
        public int ReferenzID { get; set; }
        public string ClientName { get; set; }
        public string Unternehmen { get; set; }
        public string Kommentar { get; set; }
        public string BildUrl { get; set; }
        public string Title { get; set; }
    }
}
