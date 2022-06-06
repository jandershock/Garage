namespace Garage
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            System.Console.WriteLine($"The {this.MainColor} ram truck goes by.");
        }
    }
}