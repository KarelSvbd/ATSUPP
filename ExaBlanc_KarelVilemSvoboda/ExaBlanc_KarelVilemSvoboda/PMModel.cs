using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaBlanc_KarelVilemSvoboda
{
    internal class PMModel
    {
        private readonly List<VehicleRate> _vehicleRates = new List<VehicleRate>();
        private static readonly List<int> _availableDurations = new List<int> { 15, 30, 45, 60, 75, 90, 105, 120};
        private static readonly List<string> _availableRate = new List<string> { "Moto", "Voiture", "Camionnette"};
        private VehicleRate _CurrentVehicleRate;
        private DateTime mtn = DateTime.Now;
        private string _immatriculation = null;
        private string _ticketString = null;

        public string ticketString
        {
            get { return _ticketString; }
        }
        public List<VehicleRate> VehicleRates
        {
            get { return _vehicleRates; }
        }

        public static List<int> AvailableDurations
        {
            get { return _availableDurations; }
        }

        public static List<string> AvailableRate
        {
            get { return _availableRate; }
        }

        private VehicleRate CurrentVehicleRate
        {
            get { return _CurrentVehicleRate; }
        }

        public PMModel(int pVehicleIndex, int pDurationIndex, string pImmatriculation)
        {
            _immatriculation=pImmatriculation;
            _ticketString = GenerateTicket(pVehicleIndex, pDurationIndex).ToString();
            
        }

        public Ticket GenerateTicket(int pVehicleIndex, int pDurationIndex)
        {
            string vehicule = null;
            TimeSpan duration = new TimeSpan((pDurationIndex + 1) * 15 * 10000000);
            
            switch (pVehicleIndex)
            {
                case 0:
                    vehicule = "Moto";
                    break;
                case 1:
                    vehicule = "Voiture";
                    break;
                case 2:
                    vehicule = "Camionnette";
                    break;
                    
            }

            _CurrentVehicleRate = new VehicleRate(vehicule);
            
            DateTime end = mtn.Add(new TimeSpan(Convert.ToInt32(duration.TotalSeconds) * 60));

            return new Ticket(vehicule, mtn, duration, end, _CurrentVehicleRate.ComputeParkingCost(mtn, pDurationIndex), _immatriculation);
        }
    }
}
