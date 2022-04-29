using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Core.Konkret
{
    public class Dienst
    {
        [Key]
        public int DienstID { get; set; }
        public string Title { get; set; }
        public string BildUrl { get; set; }
    }
}
