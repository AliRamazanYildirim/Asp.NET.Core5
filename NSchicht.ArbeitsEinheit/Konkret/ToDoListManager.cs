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
    public class ToDoListManager : IToDoListDienst
    {
        private readonly IToDoListDüo _toDoListDüo;

        public ToDoListManager(IToDoListDüo toDoListDüo)
        {
            _toDoListDüo = toDoListDüo;
        }

        public void TAktualisieren(ToDoList einheit)
        {
            throw new NotImplementedException();
        }

        public void TInsert(ToDoList einheit)
        {
            throw new NotImplementedException();
        }

        public void TLöschen(ToDoList einheit)
        {
            throw new NotImplementedException();
        }

        public List<ToDoList> TRufAlleDaten()
        {
            return _toDoListDüo.RufAlleDaten();
        }

        public List<ToDoList> TRufListeZurFilter()
        {
            throw new NotImplementedException();
        }

        public  ToDoList TRufZurID(int ID)
        {
            return _toDoListDüo.RufZurID(ID);
        }
    }
}
