using UnitTestingLab;

namespace UnitTestLabTests
{
    [TestClass]
    public class UnitTests
    {
        // Adding test to verify that the default number of doors is 1
        [TestMethod]
        public void TestGetDoorNumber_Default()
        {
            int result = Car.getDoorNumber();
            Assert.AreEqual(1, result, "The default number of doors should be 1.");
        }

        // Adding est to verify setting a valid number of doors 1 to 5
        [TestMethod]
        public void TestSetDoorNumber_Valid()
        {
            int validNumber = 3;

            Car.setDoorNumber(validNumber);
            int result = Car.getDoorNumber();

            Assert.AreEqual(validNumber, result, "The number of doors should be set to the valid input.");
        }

    }
}
