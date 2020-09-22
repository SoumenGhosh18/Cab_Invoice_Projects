
namespace CabInvoiceProjects
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CabInvoiceMain
    {
        public double MinCostPerKm=10;
        public int CostPerTime=1;
        public double CalculateFare(double distance, int time)
        {
            return distance*MinCostPerKm + time*CostPerTime;
        }
    }
}
