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
    public class EigenschaftManager : IGenerischesDienst<Eigenschaft>
    {
        private readonly IEigenschaftDüo _eigenschaftDüo;

        public EigenschaftManager(IEigenschaftDüo eigenschaftDüo)
        {
            _eigenschaftDüo = eigenschaftDüo;
        }

        public void TAktualisieren(Eigenschaft einheit)
        {
            _eigenschaftDüo.Aktualisieren(einheit);
        }

        public void TInsert(Eigenschaft einheit)
        {
            _eigenschaftDüo.Insert(einheit);
        }

        public void TLöschen(Eigenschaft einheit)
        {
            _eigenschaftDüo.Löschen(einheit);
        }

        public List<Eigenschaft> TRufAlleDaten()
        {
            return _eigenschaftDüo.RufAlleDaten();
        }

        public List<Eigenschaft> TRufListeZurFilter()
        {
            throw new NotImplementedException();
        }

        public Eigenschaft TRufZurID(int ID)
        {
            return _eigenschaftDüo.RufZurID(ID);
        }
    }
}
