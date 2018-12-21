using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KneatAssignment.Tests
{
    [TestClass()]
    public class HelperTests
    {
        [TestMethod()]
        public void GetStopsRequired_TestForYwing()
        {
            // Setup test data
            int expected = 74;
            int input = 1000000;
            string consumables = "1 week";
            string MGLT = "80";

            Helper helper = new Helper(); // Create an instance of the helper class
            int actual = helper.GetStopsRequired(input, consumables, MGLT);

            // Assert
            Assert.AreEqual(expected, actual, "Stops Required are not equal");
        }

        [TestMethod()]
        public void GetStopsRequired_TestForFalcon()
        {
            // Setup test data
            int expected = 9;
            int input = 1000000;
            string consumables = "2 months";
            string MGLT = "75";

            Helper helper = new Helper(); // Create an instance of the helper class
            int actual = helper.GetStopsRequired(input, consumables, MGLT);

            // Assert
            Assert.AreEqual(expected, actual, "Stops Required are not equal");
        }

        [TestMethod()]
        public void GetStopsRequired_TestForRebelTransport()
        {
            // Setup test data
            int expected = 11;
            int input = 1000000;
            string consumables = "6 months";
            string MGLT = "20";

            Helper helper = new Helper(); // Create an instance of the helper class
            int actual = helper.GetStopsRequired(input, consumables, MGLT);

            // Assert
            Assert.AreEqual(expected, actual, "Stops Required are not equal");
        }

    }
}