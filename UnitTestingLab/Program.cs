/*Heini-Linda Jennings L00188525
PgDip DevOps Sofware Engineering lab 2
Car class returning number of doors
*/
using System;

namespace UnitTestingLab
{

    //Public class created for car to include required parameters and methods
    public class Car
    {
        private static int numberOfDoors = 1;

        //Adding main method to the class
        public static void Main() { }

        //Adding method to get the number of doors
        public static int getDoorNumber()
        {
            return numberOfDoors;
        }

        //Sets the number of doors and tests if it's between 1 to 5 and returns the number
        public static void setDoorNumber(int numberOfDoors)
        {
            if (numberOfDoors < 1 || numberOfDoors > 5)
            {
                Car.numberOfDoors = 1;
            }
            else
            {
                Car.numberOfDoors = numberOfDoors;
            }

        }
    }
}