using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            System.Console.WriteLine($"The {this.MainColor} vehicle turns {direction}.");
        }

        public virtual void Stop()
        {
            System.Console.WriteLine($"The {this.MainColor} vehicle stops.");
        }
    }
}