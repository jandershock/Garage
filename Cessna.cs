using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
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