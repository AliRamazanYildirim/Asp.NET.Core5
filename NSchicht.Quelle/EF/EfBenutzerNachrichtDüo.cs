using Microsoft.EntityFrameworkCore;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.Abstrakt;
using NSchicht.Quelle.Konkret;
using NSchicht.Quelle.Quelle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Quelle.EF
{
    public class EfBenutzerNachrichtDüo : GenerischeQuelle<BenutzerNachricht>, IBenutzerNachrichtDüo
    {
        public List<BenutzerNachricht> RufBenutzerNachrichtenMitBenutzer()
        {
            using (var kontext = new Kontext())
            {
                return kontext.BenutzerNachrichten.Include(x => x.Benutzers).ToList();
            }
        }
    }
}
