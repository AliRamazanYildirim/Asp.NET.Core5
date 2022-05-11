using NSchicht.ArbeitsEinheit.Abstrakt;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.Abstrakt;
using System.Collections.Generic;

namespace NSchicht.ArbeitsEinheit.Konkret
{
    public class ÜberManager : IÜberDienst
    {
        private readonly IÜberDüo _überDüo;

        public ÜberManager(IÜberDüo überDüo)
        {
            _überDüo = überDüo;
        }

        public void TAktualisieren(Über einheit)
        {
            _überDüo.Aktualisieren(einheit);
        }

        public void TInsert(Über einheit)
        {
            _überDüo.Insert(einheit);
        }

        public void TLöschen(Über einheit)
        {
            _überDüo.Löschen(einheit);
        }

        public List<Über> TRufAlleDaten()
        {
           return _überDüo.RufAlleDaten();

        }

        public Über TRufZurID(int ID)
        {
            return _überDüo.RufZurID(ID);
        }
    }
}
