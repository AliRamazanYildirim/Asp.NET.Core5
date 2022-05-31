using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.ArbeitsEinheit.Abstrakt
{
    public interface IGenerischesDienst<T>
    {
        void TInsert(T einheit);
        void TAktualisieren(T einheit);
        void TLöschen(T einheit);
        List<T> TRufAlleDaten();
        T TRufZurID(int ID);
        List<T> TRufListeZurFilter();
    }
}
