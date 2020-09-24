using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceProjects
{
    class RideType
    {
        public static string normalRide = "Normal";
        public static  string premiumRide = "Premium";
        public int costPerTime;
        public double minimumCostPerKilometer;
        public double minimumFare;

        public RideType(string rideType)
        {
            if (rideType.ToLower() == premiumRide)
            {
                costPerTime = 2;
                minimumCostPerKilometer = 15;
                minimumFare = 20;
            }
            else
            {
                costPerTime = 1;
                minimumCostPerKilometer = 10;
                minimumFare = 5;
            }
        }
    }
}
