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
    public class DienstManager : IDienstDienst
    {
        private readonly IDienstDüo _dienstDüo;

        public DienstManager(IDienstDüo dienstDüo)
        {
            _dienstDüo = dienstDüo;
        }

        public void TAktualisieren(Dienst einheit)
        {
            _dienstDüo.Aktualisieren(einheit);
        }

        public void TInsert(Dienst einheit)
        {
            _dienstDüo.Insert(einheit);
        }

        public void TLöschen(Dienst einheit)
        {
            _dienstDüo.Löschen(einheit);
        }

        public List<Dienst> TRufAlleDaten()
        {
           return _dienstDüo.RufAlleDaten();
        }

        public Dienst TRufZurID(int ID)
        {
            return _dienstDüo.RufZurID(ID);
        }
    }
}
