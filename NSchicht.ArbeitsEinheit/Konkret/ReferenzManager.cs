using NSchicht.ArbeitsEinheit.Abstrakt;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.Abstrakt;
using System.Collections.Generic;

namespace NSchicht.ArbeitsEinheit.Konkret
{
    public class ReferenzManager:IReferenzDienst
    {
        private readonly IReferenzDüo _referenzDüo;

        public ReferenzManager(IReferenzDüo referenzDüo)
        {
            _referenzDüo = referenzDüo;
        }

        public void TAktualisieren(Referenz einheit)
        {
            _referenzDüo.Aktualisieren(einheit);
        }

        public void TInsert(Referenz einheit)
        {
            _referenzDüo.Insert(einheit);
        }

        public void TLöschen(Referenz einheit)
        {
            _referenzDüo.Löschen(einheit);
        }

        public List<Referenz> TRufAlleDaten()
        {
            return _referenzDüo.RufAlleDaten();
        }

        public Referenz TRufZurID(int ID)
        {
           return _referenzDüo.RufZurID(ID);
        }
    }
}
