namespace floatType.Models
{
    public class Vehicle
    {
        public string Name = "Ajikuku";
        public string Brand { get; set; }
        public bool IsNew { get; set; } = true;

        protected string OwnerName { get; set; }

        public virtual void IsNewVehicle(bool yangi)
        {
            IsNew = yangi;
        }

        public virtual void getAllData()
        {
            System.Console.WriteLine($"Yangi : {IsNew}");
        }


    }
}
