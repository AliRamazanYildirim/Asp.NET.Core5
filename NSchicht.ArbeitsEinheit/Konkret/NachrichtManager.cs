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
    public class NachrichtManager : INachrichtDienst
    {
        private readonly INachrichtDüo _nachrichtDüo;

        public NachrichtManager(INachrichtDüo nachrichtDüo)
        {
            _nachrichtDüo = nachrichtDüo;
        }

        public void TAktualisieren(Nachricht einheit)
        {
            _nachrichtDüo.Aktualisieren(einheit);
        }

        public void TInsert(Nachricht einheit)
        {
            _nachrichtDüo.Insert(einheit);
        }

        public void TLöschen(Nachricht einheit)
        {
            _nachrichtDüo.Löschen(einheit);
        }

        public List<Nachricht> TRufAlleDaten()
        {
            return _nachrichtDüo.RufAlleDaten();
        }

        public Nachricht TRufZurID(int ID)
        {
            return _nachrichtDüo.RufZurID(ID);
        }
    }
}
