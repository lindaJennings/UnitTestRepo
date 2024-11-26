/*Heini-Linda Jennings L00188525
PgDip DevOps Sofware Engineering lab 2
Unit testing for car class
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDoorTest;

namespace CarTestScript 
{
[TestClass]

    // Adding public test class for unit tests
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