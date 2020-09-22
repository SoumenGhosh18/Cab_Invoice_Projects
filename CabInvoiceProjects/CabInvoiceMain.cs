
namespace CabInvoiceProjects
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CabInvoiceMain
    {
        public double MIN_COST_PER_KM=10;
        public int COST_PER_TIME=1;
        public int MIN_FARE =5;
        public double CalculateFare(double distance, int time)
        {
            double totalFare= distance* MIN_COST_PER_KM + time* COST_PER_TIME;
            if (totalFare < MIN_FARE)
                return MIN_FARE;
            return totalFare;
        }

        public double CalculateFare(Ride[] rides)
        {
            double totalFare = 0;
            foreach(Ride ride in rides)
                {
                totalFare  = totalFare+ this.CalculateFare(ride.distance, ride.time);
            }
            return totalFare;
        }
    }
}
