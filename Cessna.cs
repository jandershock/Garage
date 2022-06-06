using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; } = 200;
        public double CurrentFuel { get; set; } = 20;
        public double CurrentTankPercentage { 
            get
            {
                return (CurrentFuel / FuelCapacity) * 100;
            } 
            set {}
        }

        public void RefuelTank()
        {
            CurrentFuel = FuelCapacity;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Cessna goes Zoooooom!");
        }

        public override void Stop()
        {
            System.Console.WriteLine($"The {this.MainColor} Cessna stops on the runway.");
        }
    }
}