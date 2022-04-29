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
    }
}
