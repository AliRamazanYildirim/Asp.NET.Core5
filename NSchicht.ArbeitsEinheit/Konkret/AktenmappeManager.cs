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
    public class AktenmappeManager: IAktenmappeDienst
    {
        private readonly IAktenmappeDüo _aktenmappeDüo;

        public AktenmappeManager(IAktenmappeDüo aktenmappeDüo)
        {
            _aktenmappeDüo = aktenmappeDüo;
        }

        public void TAktualisieren(Aktenmappe einheit)
        {
            _aktenmappeDüo.Aktualisieren(einheit);
        }

        public void TInsert(Aktenmappe einheit)
        {
            _aktenmappeDüo.Insert(einheit);
        }

        public void TLöschen(Aktenmappe einheit)
        {
            _aktenmappeDüo.Löschen(einheit);
        }

        public List<Aktenmappe> TRufAlleDaten()
        {
           return _aktenmappeDüo.RufAlleDaten();
        }

        public Aktenmappe TRufZurID(int ID)
        {
            return _aktenmappeDüo.RufZurID(ID);
        }
    }
}
