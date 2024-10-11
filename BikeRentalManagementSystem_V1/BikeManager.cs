using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    public class BikeManager
    {

        public BikeManager()
        {
            BikeList = new List<Bike>();
        }
        public List<Bike> BikeList;

        public void CreateBike()
        {
            Console.WriteLine("Enter the ID");
            var BikeId = Console.ReadLine();
            Console.WriteLine("Enter the Brand");
            var Brand = Console.ReadLine();
            Console.WriteLine("Enter the Model");
            var Model = Console.ReadLine();
            Console.WriteLine("Enter the Rental Price");
            var RentalPrice = decimal.Parse(Console.ReadLine());

            var bikes = new Bike()
            {
                //BikeId = BikeId,
                Brand = Brand,
                Model = Model,
                RentalPrice = RentalPrice
            };
            this.BikeList.Add(bikes);
            Console.WriteLine("Successfully Created");
        }

        public void ReadBikes()
        {
            if (BikeList.Count > 0)
            {
                foreach (var item in BikeList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("No Bikes Available");
            }
        }

        public void UpdateBike()
        {
            Console.WriteLine("Enter the ID");
            var BikeId = Console.ReadLine();
            //var FindId = this.BikeList.Where(p => p.BikeId == BikeId).SingleOrDefault();
            if (BikeId != null)
            {
                //this.BikeList.Remove(FindId);
                Console.WriteLine("Enter the Brand");
                var NBrand = Console.ReadLine();
                Console.WriteLine("Enter the Model");
                var NModel = Console.ReadLine();
                Console.WriteLine("Enter the Rental Price");
                var NPrice = decimal.Parse(Console.ReadLine());

                var newBikes = new Bike()
                {
                    //BikeId = BikeId,
                    Brand = NBrand,
                    Model = NModel,
                    RentalPrice = NPrice
                };
                this.BikeList.Add(newBikes);
                Console.WriteLine("Successfully Updated");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        public void DeleteBike()
        {
            Console.WriteLine("Enter the ID");
            var BikeId = Console.ReadLine();
            //var FindId = this.BikeList.Where(p => p.BikeId == BikeId).SingleOrDefault();
            if (BikeId != null)
            {
                //this.BikeList.Remove(FindId);
                Console.WriteLine("Succesfully Deleted");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }



    }
    

}

