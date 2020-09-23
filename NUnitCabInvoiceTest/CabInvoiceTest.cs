

 namespace NUnitCabInvoiceTest
{
    using CabInvoiceProjects;
    using NUnit.Framework;
    using System.Collections.Generic;

    public class CabInvoiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenDistanceAndTime_ShouldReturnTotalFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            Assert.AreEqual(25, fare);
        }

        [Test]
        public void GivenLessDistanceAndTime_ShouldReturnMinFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 0.1;
            int time = 1;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            Assert.AreEqual(5, fare);
        }

        [Test]
        public void GivenMultipleRides_ShouldReturnTotalFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            string userId = "soumen";
            Rides firstRide = new Rides(2.0, 5);
            Rides secondRide = new Rides(0.1, 1);
            List<Rides> rides = new List<Rides> { firstRide, secondRide };
            RideRepository.AddRides(userId, rides);
            InvoiceSummary invoiceSummary = invoiceGenerator.GetInvoiceSummary(userId);
            double expected = 30;
            Assert.AreEqual(expected, invoiceSummary.TotalFare);
        }

        [Test]
        public void GivenUSerId_ShouldReturnInvoiceSummary()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            string userId = "soumen";
            Rides firstRide = new Rides(3.0, 5);
            Rides secondRide = new Rides(1, 1);
            List<Rides> rides = new List<Rides> { firstRide, secondRide };
            RideRepository.AddRides(userId, rides);
            InvoiceSummary invoiceSummary = invoiceGenerator.GetInvoiceSummary(userId);
            InvoiceSummary expected = new InvoiceSummary
            {
                TotalNumberOfRides = 2,
                TotalFare = 46,
                AverageFarePerRide = 23
            };
            object.Equals(expected, invoiceSummary);
        }

      
    }
}