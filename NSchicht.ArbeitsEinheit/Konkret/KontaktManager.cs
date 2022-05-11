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
    public class KontaktManager:IKontaktDienst
    {
        private readonly IKontaktDüo _kontaktDüo;

        public KontaktManager(IKontaktDüo kontaktDüo)
        {
            _kontaktDüo = kontaktDüo;
        }

        public void TAktualisieren(Kontakt einheit)
        {
            _kontaktDüo.Aktualisieren(einheit);
        }

        public void TInsert(Kontakt einheit)
        {
            _kontaktDüo.Insert(einheit);
        }

        public void TLöschen(Kontakt einheit)
        {
            _kontaktDüo.Löschen(einheit);
        }

        public List<Kontakt> TRufAlleDaten()
        {
            return _kontaktDüo.RufAlleDaten();
        }

        public Kontakt TRufZurID(int ID)
        {
            return _kontaktDüo.RufZurID(ID);
        }
    }
}
