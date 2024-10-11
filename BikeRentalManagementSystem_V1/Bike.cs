using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class Bike
    {
        public Bike(string bikeId, string Brand, string Model, decimal RentalPrice)
        {
           
        }
        private string bikeId { get; set; }
        private string Brand { get; set; }
        private string Model { get; set; }
        private decimal RentalPrice { get; set; }


        public override string ToString()
        {
            return $"Bike ID: {bikeId}, Brand: {Brand}, Model: {Model}, Rental Price: {RentalPrice}\r\n";
        }


    }
}
