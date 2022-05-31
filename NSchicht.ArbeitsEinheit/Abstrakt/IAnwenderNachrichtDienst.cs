using NSchicht.Core.Konkret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSchicht.ArbeitsEinheit.Abstrakt
{
    public interface IAnwenderNachrichtDienst: IGenerischesDienst<AnwenderNachricht>
    {
        List<AnwenderNachricht> RufListeAbsenderNachrichten(string mail);
        List<AnwenderNachricht> RufListeEmpfaengerNachrichten(string mail);
    }
}
