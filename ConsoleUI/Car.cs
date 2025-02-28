using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool HasTrunk { get; set; }
        public override void DriveAbstract()
        {
            
        }
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Car is driving,");
        }
    }
}
