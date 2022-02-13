namespace floatType.Models
{
    public class Bicycle : Vehicle
    {
        public override void IsNewVehicle(bool yangi)
        {
            IsNew = yangi;
        }

        public override void getAllData()
        {
            System.Console.WriteLine($"Yangi : {IsNew}");
        }
    }
}