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
    public class FaehigkeitManager:IFaehigkeitsDienst
    {
        private readonly IFaehigkeitDüo _faehigkeitDüo;

        public FaehigkeitManager(IFaehigkeitDüo faehigkeitDüo)
        {
            _faehigkeitDüo = faehigkeitDüo;
        }

        public void TAktualisieren(Faehigkeit einheit)
        {
            _faehigkeitDüo.Aktualisieren(einheit);
        }

        public void TInsert(Faehigkeit einheit)
        {
            _faehigkeitDüo.Insert(einheit);
        }

        public void TLöschen(Faehigkeit einheit)
        {
            _faehigkeitDüo.Löschen(einheit);
        }

        public List<Faehigkeit> TRufAlleDaten()
        {
           return _faehigkeitDüo.RufAlleDaten();
        }

        public Faehigkeit TRufZurID(int ID)
        {
           return _faehigkeitDüo.RufZurID(ID);
        }
    }
}
