using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem_V1
{
    internal class ElectricBike :Bike
    {
        public ElectricBike() : base()
        {

        }
        public string BatteryCapacity { get; set; }
        public string MotorPower { get; set; }


        public static string DisplayElectricBikeInfo()
        {
            return $" Brand:{Brand}, Model: {Model}, Rental Price: {RentalPrice}, Battery Capazity: {BatteryCapacity}, Motor Power: {MotorPower}";
        }

        public override string DisplayBikeInfo()
        {
            return $"Bike Id: {BikeId}, Brand:{Brand}, Model:{Model}, Rental Price: {RentalPrice} , Battery Capazity: {BatteryCapacity}, Motor Power{MotorPower}" ;
        }
    }
}
