namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; } = 50;
        

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
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