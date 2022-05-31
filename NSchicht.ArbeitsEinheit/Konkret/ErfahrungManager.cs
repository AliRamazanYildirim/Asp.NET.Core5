using NSchicht.ArbeitsEinheit.Abstrakt;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.Abstrakt;
using System.Collections.Generic;

namespace NSchicht.ArbeitsEinheit.Konkret
{
    public class ErfahrungManager: IErfahrungsDienst
    {
        private readonly IErfahrungDüo _erfahrungDüo;

        public ErfahrungManager(IErfahrungDüo erfahrungDüo)
        {
            _erfahrungDüo = erfahrungDüo;
        }

        public void TAktualisieren(Erfahrung einheit)
        {
            _erfahrungDüo.Aktualisieren(einheit);
        }

        public void TInsert(Erfahrung einheit)
        {
            _erfahrungDüo.Insert(einheit);
        }

        public void TLöschen(Erfahrung einheit)
        {
            _erfahrungDüo.Löschen(einheit);
        }

        public List<Erfahrung> TRufAlleDaten()
        {
            return _erfahrungDüo.RufAlleDaten();
        }

        public List<Erfahrung> TRufListeZurFilter()
        {
            throw new System.NotImplementedException();
        }

        public Erfahrung TRufZurID(int ID)
        {
            return _erfahrungDüo.RufZurID(ID);
        }
    }
}
