using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {

        public bool HasSideSeat { get; set; }
        public override void DriveAbstract()
        {
            
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"Motorcycle is driving.");
        }
    }
}
