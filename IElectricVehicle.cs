namespace Garage
{
    public interface IElectricVehicle
    {
        double BatteryKWh { get; }
        void ChargeBattery();
        double CurrentChargePercentage { get; set; }
    }
}