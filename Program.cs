namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram ramTruck = new Ram();

            fxs.MainColor = "red";
            fxs.MaximumOccupancy = 2;
            modelS.MainColor = "blue";
            modelS.MaximumOccupancy = 4;
            mx410.MainColor = "white";
            mx410.MaximumOccupancy = 2;
            ramTruck.MainColor = "green";
            ramTruck.MaximumOccupancy = 5;

            
            fxs.Drive();
            fxs.Turn("Left");
            fxs.Stop();

            modelS.Drive();
            modelS.Turn("Left");
            modelS.Stop();
            
            mx410.Drive();
            mx410.Turn("Right");
            mx410.Stop();

            ramTruck.Drive();
            ramTruck.Turn("Right");
            ramTruck.Stop();
        }
    }
}