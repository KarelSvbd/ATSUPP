using System;

namespace ExaBlanc_KarelVilemSvoboda
{
    internal class Ticket
    {
        private readonly string _vehiculeType;
        private readonly DateTime _begin;
        private readonly TimeSpan _duration;
        private readonly DateTime _end;
        private readonly decimal _cost;
        private readonly string _immatriculation;

        public string VehiculeType
        {
            get { return _vehiculeType;}
        }

        public DateTime Begin
        {
            get { return _begin; }
        }

        public TimeSpan Duration
        {
            get { return _duration; }
        }

        public DateTime End
        {
            get { return _end; }
        }

        public decimal Cost
        {
            get { return _cost; }
        }

        public Ticket(string pVehiculeType, DateTime pBegin, TimeSpan pDuration, DateTime pEnd, decimal pCost, string pImmatriculation)
        {
            _vehiculeType = pVehiculeType;
            _begin = pBegin;
            _duration = pDuration;
            _end = pEnd;
            _cost = pCost;
            _immatriculation = pImmatriculation;
        }

        public override string ToString()
        {
            return "véhicule : " + _vehiculeType + Environment.NewLine + "immatriculation : " + _immatriculation + Environment.NewLine + "début : " + _begin.ToString() + Environment.NewLine + "fin : " + _end.ToString() + Environment.NewLine + "durée : " + (_duration.Seconds + _duration.Minutes * 60).ToString() + " min" + Environment.NewLine + "coût : " + _cost.ToString() + " CHF";

        }
    }
}
