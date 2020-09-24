namespace CabInvoiceProjects
{
    public class Rides
    {
        public double distance;
        public int time;
        public string rideType;

        public Rides(double inputDistance, int inputTime, string inputRideType = "Normal")
        {
            distance = inputDistance;
            time = inputTime;
            rideType = inputRideType;
        }
    }
}