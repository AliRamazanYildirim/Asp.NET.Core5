using NSchicht.Core.Konkret;
using NSchicht.Quelle.Abstrakt;
using NSchicht.Quelle.Quelle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.Quelle.EF
{
    public class EfToDoListDüo : GenerischeQuelle<ToDoList>, IToDoListDüo
    {
    }
}
