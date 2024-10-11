using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class PetrolBike :Bike
    {
        public string FuelTankCapacity { get; set; }
        public string EngineCapacity { get; set; }

        public static string DisplayPetrolBikeInfo()
        {
            return $" Brand:{Brand}, Model: {Model}, Rental Price: {RentalPrice}, Fuel Tank Capacity: {FuelTankCapacity}, Engine Capacity: {EngineCapacity}";
        }

        public override string DisplayBikeInfo()
        {
            return $"Bike Id: {BikeId}, Brand:{Brand}, Model:{Model}, Rental Price: {RentalPrice} , Fuel Tank Capacity: {FuelTankCapacity}, Engine Capacity{EngineCapacity}";
        }

    }
}
