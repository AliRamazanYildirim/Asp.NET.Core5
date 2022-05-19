using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Core.Konkret
{
    public class IdentityBenutzer:IdentityUser<int>
    {
        public string Name { get; set; }
        public string NachName { get; set; }
        public string BildUrl { get; set; }

    }
}
