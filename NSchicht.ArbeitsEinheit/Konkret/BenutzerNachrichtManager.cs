using NSchicht.ArbeitsEinheit.Abstrakt;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.Abstrakt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.ArbeitsEinheit.Konkret
{
    public class BenutzerNachrichtManager : IBenutzerNachrichtDienst
    {
        private readonly IBenutzerNachrichtDüo _benutzerNachrichtDüo;

        public BenutzerNachrichtManager(IBenutzerNachrichtDüo benutzerNachrichtDüo)
        {
            _benutzerNachrichtDüo = benutzerNachrichtDüo;
        }

        public List<BenutzerNachricht> RufBenutzerNachrichtMitBenutzerDienst()
        {
           return _benutzerNachrichtDüo.RufBenutzerNachrichtenMitBenutzer();
        }

        public void TAktualisieren(BenutzerNachricht einheit)
        {
            _benutzerNachrichtDüo.Aktualisieren(einheit);
        }

        public void TInsert(BenutzerNachricht einheit)
        {
            _benutzerNachrichtDüo.Insert(einheit);
        }

        public void TLöschen(BenutzerNachricht einheit)
        {
            _benutzerNachrichtDüo.Löschen(einheit);
        }

        public List<BenutzerNachricht> TRufAlleDaten()
        {
           return _benutzerNachrichtDüo.RufAlleDaten();
        }

        public BenutzerNachricht TRufZurID(int ID)
        {
           return _benutzerNachrichtDüo.RufZurID(ID);
        }
    }
}
