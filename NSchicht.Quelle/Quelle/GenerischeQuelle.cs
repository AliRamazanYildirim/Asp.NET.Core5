using NSchicht.Quelle.Abstrakt;
using NSchicht.Quelle.Konkret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Quelle.Quelle
{
    public class GenerischeQuelle<T> : IGenerischeDüo<T> where T : class
    {
        public void Aktualisieren(T einheit)
        {
            using var w = new Kontext();
            w.Update(einheit);
            w.SaveChanges();
        }

        public void Insert(T einheit)
        {
            using var w = new Kontext();
            w.Add(einheit);
            w.SaveChanges();
        }

        public void Löschen(T einheit)
        {
            using var w = new Kontext();
            w.Remove(einheit);
            w.SaveChanges();
        }

        public List<T> RufAlleDaten()
        {
            using var w = new Kontext();
            return w.Set<T>().ToList();
            
        }

        public List<T> RufZurFilter(Expression<Func<T, bool>> filter)
        {
            using var w = new Kontext();
            return w.Set<T>().Where(filter).ToList();
        }

        public T RufZurID(int ID)
        {
            using var w = new Kontext();
            return w.Set<T>().Find(ID);
        }
    }
}
