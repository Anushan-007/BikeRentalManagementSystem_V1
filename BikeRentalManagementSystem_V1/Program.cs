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
            Menu();
            Console.ReadLine();
        }

        public static void Menu()
        {
            var Bike1 = new Bike("BIKE_001", "YAMAHA", "mt-15", 10.00M);
            Console.WriteLine(Bike1.ToString());

            var ManagerObj = new BikeManager();

            
            while (true)
            {
                Console.WriteLine("................................");
                Console.WriteLine("Bike Rental Management System: ");
                Console.WriteLine("1. Add a Bike: ");
                Console.WriteLine("2. View All Bikes: ");
                Console.WriteLine("3. Update a Bike: ");
                Console.WriteLine("4. Delete a Bike: ");
                Console.WriteLine("5. Exit: ");
                Console.Write("Choose an option: ");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ManagerObj.CreateBike();
                        break;
                    case "2":
                        ManagerObj.ReadBikes();
                        break;
                    case "3":
                        ManagerObj.UpdateBike();
                        break;
                    case "4":
                        ManagerObj.DeleteBike();
                        break;
                    case "5":
                       
                        break;
                    default:
                        Console.Clear();
                        Menu();
                        break;
                }


            }
        }
    }
}
