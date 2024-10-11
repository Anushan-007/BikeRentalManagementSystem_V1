using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Bike1 = new Bike("BIKE_001", "YAMAHA", "mt-15", 10.00M);
            Console.WriteLine(Bike1.ToString());
            Console.ReadLine();
        }
    }
}
