using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaBlanc_KarelVilemSvoboda
{
    internal class VehicleRate
    {
        private string _name;
        private decimal _costFor15Min;

        public string Name
        {
            get { return _name; }
        }
        public decimal CostFor15Min {
            get { return _costFor15Min; } 
        }

        public VehicleRate(string pName)
        {
            _name = pName;
        }

        private decimal GetCostBy15min()
        {
            switch (_name)
            {
                case "Moto":
                    return 0.75m;
                case "Voiture":
                    return 1m;
                case "Camionnette":
                    return 1.50m;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Retourne le coûts de stationnement
        /// </summary>
        /// <param name="pBegin"></param>
        /// <param name="pDuration"></param>
        /// <returns></returns>
        public decimal ComputeParkingCost(DateTime pBegin, int pDuration)
        {
            /*if (pBegin.Hour >= 19 || pBegin.Hour <= 6)
            {
                return 0;
            }*/

            return GetCostBy15min() * (pDuration  + 1);
        }
    }
}
