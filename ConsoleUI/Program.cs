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


            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             *  done Create an abstract class called Vehicle
             * done The vehicle class shall have three string properties Year, Make, and Model
             * done Set the defaults to something generic in the Vehicle class
             * done Vehicle shall have an abstract method called DriveAbstract with no implementation
             * done Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * done Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             *  done Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             *  done Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            var car1 = new Car() {
                HasTrunk = true,
                Year = "1989",
                Make = "Ford",
                Model = "Bronco"}; 

            var motorcycle1 = new Motorcycle() {
                HasSideCart = true,
                Year = "1987",
                Make = "Honda",
                Model = "Sportster"};

            Vehicle vehicle1 = new Car() { 
               HasTrunk = false,
                Year = "1958",
                Make = "MG",
                Model = "Roadster"};
            Vehicle motorcycle2 = new Motorcycle() { 
                HasSideCart = false,
                Year = "1936",
                Make = "Indian",
                Model = "Chief"};




            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car1);
            vehicles.Add (motorcycle1);
            vehicles.Add (vehicle1 );
            vehicles.Add(motorcycle2);

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine();
                vehicle.DriveVirtural();
                vehicle.DriveAbstract();
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle



            #endregion            
            Console.ReadLine();
        }
    }
}
