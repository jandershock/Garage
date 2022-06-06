namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            System.Console.WriteLine($"The {this.MainColor} Tesla sneaks by.");
        }

        public override void Turn(string direction)
        {
            System.Console.WriteLine($"The {this.MainColor} Tesla turns ${direction}.");
        }
    }
}