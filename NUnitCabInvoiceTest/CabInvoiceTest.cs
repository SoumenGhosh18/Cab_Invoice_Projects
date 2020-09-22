

namespace NUnitCabInvoiceTest
{
    using CabInvoiceProjects;
    using NUnit.Framework;
    public class CabInvoiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given_Distance_And_Time_Should_Return_The_Total_Fare()
        {
            CabInvoiceMain cabInvoice = new CabInvoiceMain();
            double distance =2.0;
            int time = 5;
            double fare = cabInvoice.CalculateFare(distance, time);
            Assert.AreEqual(25.0, fare);
        }

        [Test]
        public void Given_Less_Distance_And_Time_Should_Return_The_Min_Fare()
        {
            CabInvoiceMain cabInvoice = new CabInvoiceMain();
            double distance = 0.1;
            int time = 1;
            double fare = cabInvoice.CalculateFare(distance, time);
            Assert.AreEqual(5.0, fare);

        }

    }
}