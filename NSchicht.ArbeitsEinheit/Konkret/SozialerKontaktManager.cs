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
    public class SozialerKontaktManager: ISozialerKontaktDienst
    {
        private readonly ISozialerKontaktDüo _sozialerKontaktDüo;

        public SozialerKontaktManager(ISozialerKontaktDüo sozialerKontaktDüo)
        {
            _sozialerKontaktDüo = sozialerKontaktDüo;
        }

        public void TAktualisieren(SozialerKontakt einheit)
        {
            _sozialerKontaktDüo.Aktualisieren(einheit);
        }

        public void TInsert(SozialerKontakt einheit)
        {
            _sozialerKontaktDüo.Insert(einheit);
        }

        public void TLöschen(SozialerKontakt einheit)
        {
            _sozialerKontaktDüo.Löschen(einheit);
        }

        public List<SozialerKontakt> TRufAlleDaten()
        {
           return _sozialerKontaktDüo.RufAlleDaten();
        }

        public List<SozialerKontakt> TRufListeZurFilter()
        {
            throw new NotImplementedException();
        }

        public SozialerKontakt TRufZurID(int ID)
        {
            return _sozialerKontaktDüo.RufZurID(ID);
        }
    }
}
