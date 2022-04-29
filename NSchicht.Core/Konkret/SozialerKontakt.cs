using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Core.Konkret
{
    public class SozialerKontakt
    {
        [Key]
        public int SozialerKontaktID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Ikon { get; set; }
        public bool Status { get; set; }
    }
}
