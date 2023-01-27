using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "default value";
        public string Make { get; set; } = "default value";
        public string Model { get; set; } = "default value";

        public abstract void DriveAbstract();

        public virtual void DriveVirtural()
        {
            Console.WriteLine("Default Virtual Drive Method");
        }
    }
}
