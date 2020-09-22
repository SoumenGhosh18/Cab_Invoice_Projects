using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceProjects
{
    public class InvoiceSumarry
    {
        public  int numberOfRides;
        public double totalFare;
        public double averageFare;
        
        
        public InvoiceSumarry(int numberOfRides, double totalFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare =(this.totalFare/this.numberOfRides);
        }

        public override bool Equals(object obj)
        {
            return obj is InvoiceSumarry sumarry &&
                   numberOfRides == sumarry.numberOfRides &&
                   totalFare == sumarry.totalFare &&
                   averageFare == sumarry.averageFare;
        }
    }
}
