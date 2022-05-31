using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Quelle.Abstrakt
{
    public interface IGenerischeDüo<T> where T : class
    {
        void Insert(T einheit);
        void Aktualisieren(T einheit);
        void Löschen(T einheit);
        List<T> RufAlleDaten();
        T RufZurID(int ID);
        List<T> RufZurFilter(Expression<Func<T,bool>>filter);
    }
}
