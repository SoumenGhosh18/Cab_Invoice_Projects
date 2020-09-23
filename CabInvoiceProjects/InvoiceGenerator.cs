using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceProjects
{
    public class InvoiceGenerator
    {
        private static int costPerTime = 1;
        private static double minimumCostPerKilometer = 10;
        private static double minimumFare = 5;

        public double CalculateFare(double distance, int time)
        {
            double totalFare = distance * minimumCostPerKilometer + time * costPerTime;
            if (totalFare < minimumFare)
            {
                return minimumFare;
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
                    totalFare += this.CalculateFare(ride.distance, ride.time);
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


