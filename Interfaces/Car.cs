using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    
        public class Car : IVehicle
        {

            public int fuelTank { get; set; }

            public Car()
            {
                fuelTank = 0;
            }
           
            public void Drive()
            {
                if (fuelTank < 1)
                {
                    Console.WriteLine("Can't drive");
                }
                else
                {
                    Console.WriteLine("Driving");
                }

            }

            public bool Refuel(int liters)
            {
                fuelTank += liters;
                return true;
            }
        }
    
}
