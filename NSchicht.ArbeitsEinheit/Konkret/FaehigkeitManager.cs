﻿using NSchicht.ArbeitsEinheit.Abstrakt;
using NSchicht.Core.Konkret;
using NSchicht.Quelle.Abstrakt;
using System.Collections.Generic;

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

        public List<Faehigkeit> TRufListeZurFilter()
        {
            throw new System.NotImplementedException();
        }

        public Faehigkeit TRufZurID(int ID)
        {
           return _faehigkeitDüo.RufZurID(ID);
        }
    }
}
