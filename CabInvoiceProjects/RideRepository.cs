
namespace CabInvoiceProjects
{
    using System;
    using System.Collections.Generic;

    public class RideRepository
    {
        public static Dictionary<string, List<Rides>> account = new Dictionary<string, List<Rides>>();

        public static void AddRides(string key, List<Rides> inputRides)
        {
            if (account.ContainsKey(key))
            {
                foreach (Rides ride in inputRides)
                {
                    account[key].Add(ride);
                }
            }
            else
            {
                account.Add(key, inputRides);
            }
        }
    }
}

