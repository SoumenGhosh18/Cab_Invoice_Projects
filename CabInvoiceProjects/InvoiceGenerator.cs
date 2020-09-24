using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceProjects
{
    public class InvoiceGenerator
    {
        
        public double CalculateFare(double distance, int time, string type)
        {
            RideType rideType = new RideType(type);
            double totalFare = distance * rideType.minimumCostPerKilometer + time * rideType.costPerTime;
            if (totalFare < rideType.minimumFare)
            {
                return rideType.minimumFare;
            }
            return totalFare;
        }

        public InvoiceSummary GetInvoiceSummary(string userId)
        {
            InvoiceSummary invoiceSummary = new InvoiceSummary();
            double totalFare = 0;
            int numberOfRides = 0;

            if (RideRepository.account.ContainsKey(userId))
            {

                foreach (Rides ride in RideRepository.account[userId])
                {
                    totalFare += this.CalculateFare(ride.distance, ride.time, ride.rideType);
                    numberOfRides++;
                }

            }
            invoiceSummary.TotalNumberOfRides = numberOfRides;
            invoiceSummary.TotalFare = totalFare;
            invoiceSummary.CalculateAvergaeFare();
            return invoiceSummary;

        }
    }
}


