using System;
using System.Collections.Generic;
using System.IO;
using floatType.Models;
namespace floatType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle();

            bicycle.Brand = "Ice";
            bicycle.Name = "Motorolla";
            bicycle.IsNew = true;
            bicycle.IsNewVehicle(true);

            Vehicle car = new Vehicle();
            car.IsNewVehicle(false);

            System.Console.WriteLine($"Mashina yangiligi {car.IsNew}");
            System.Console.WriteLine($"Velosiped yangiligi {bicycle.IsNew}");
        }

    }
}
