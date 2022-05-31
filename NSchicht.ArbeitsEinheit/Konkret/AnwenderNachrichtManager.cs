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
    public class AnwenderNachrichtManager:  IAnwenderNachrichtDienst
    {
        private readonly IAnwenderNachrichtDüo _anwenderNachrichtDüo;

        public AnwenderNachrichtManager(IAnwenderNachrichtDüo anwenderNachrichtDüo)
        {
            _anwenderNachrichtDüo = anwenderNachrichtDüo;
        }

        public List<AnwenderNachricht> RufListeAbsenderNachrichten(string mail)
        {
            return _anwenderNachrichtDüo.RufZurFilter(x => x.Absender == mail);
        }

        public List<AnwenderNachricht> RufListeEmpfaengerNachrichten(string mail)
        {
            return _anwenderNachrichtDüo.RufZurFilter(x => x.Empfaenger == mail);
        }

        public void TAktualisieren(AnwenderNachricht einheit)
        {
            throw new NotImplementedException();
        }

        public void TInsert(AnwenderNachricht einheit)
        {
            _anwenderNachrichtDüo.Insert(einheit);
        }

        public void TLöschen(AnwenderNachricht einheit)
        {
            _anwenderNachrichtDüo.Löschen(einheit);
        }

        public List<AnwenderNachricht> TRufAlleDaten()
        {
            throw new NotImplementedException();
        }


        public List<AnwenderNachricht> TRufListeZurFilter()
        {
            throw new NotImplementedException();
        }

        public AnwenderNachricht TRufZurID(int ID)
        {
            return _anwenderNachrichtDüo.RufZurID(ID);
        }
    }
}
