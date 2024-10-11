using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    public class Bike
    {
        public Bike()
        {
            TotalCount++;
        }

        public Bike(string bikeId, string Brand, string Model, decimal RentalPrice)
        {
            TotalCount++;
        }
        public string bikeId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal RentalPrice { get; set; }

        public int TotalCount { get; set; } 


        public override string ToString()
        {
            return $"Bike ID: {bikeId}, Brand: {Brand}, Model: {Model}, Rental Price: {RentalPrice}\r\n";
        }

        //public virtual string DisplayBikeInfo()
        //{
        //    return $"Bike Id: {BikeId}, Brand:{Brand}, Model:{Model}, Rental Price: {RentalPrice}";
        //}


    }
}
