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
    public class AutorAnwenderManager : IAutorAnwenderDienst
    {
        private readonly IAutorAnwenderDüo _autorAnwenderDüo;

        public AutorAnwenderManager(IAutorAnwenderDüo autorAnwenderDüo)
        {
            _autorAnwenderDüo = autorAnwenderDüo;
        }

        public void TAktualisieren(IdentityBenutzer einheit)
        {
            throw new NotImplementedException();
        }

        public void TInsert(IdentityBenutzer einheit)
        {
            throw new NotImplementedException();
        }

        public void TLöschen(IdentityBenutzer einheit)
        {
            throw new NotImplementedException();
        }

        public List<IdentityBenutzer> TRufAlleDaten()
        {
            return _autorAnwenderDüo.RufAlleDaten();
        }

        public List<IdentityBenutzer> TRufListeZurFilter()
        {
            throw new NotImplementedException();
        }

        public IdentityBenutzer TRufZurID(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
