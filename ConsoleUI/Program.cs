using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();

            var car1 = new Car() { 
                HasTrunk = true, 
                Year = "1971",
                Make = "Ford",
                Model = "F100"

            };
            var motorcycle1 = new Motorcycle() { 
                HasSideSeat = true,
                Year = "1994",
                Make = "Ducati",
                Model = "916"
            };
            Vehicle vehicle1 = new Car() { 
                Year = "1992",
                HasTrunk = true,
                Make = "Astin",
                Model = "Martin"

            };
            Vehicle vehicle2 = new Motorcycle()
            {
                Make = "Indian",
                Model = "101 Scout",
                Year = "1928",
                HasSideSeat = true
            };
            

            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model:{vehicle.Model}");
                Console.WriteLine();
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine();
            }


            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            




            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle



            
        }
    }
}
