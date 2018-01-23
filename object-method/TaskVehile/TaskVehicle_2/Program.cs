using System;


namespace TaskVehicle_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perintä testeri");
            Vehicle vehicle = new Vehicle("Henkilöauto", "Audi", 2010, 25000);
            Car car = new Car("Henkilöauto", "VW", 2012, 20000, 2.0, "Passat", 5);

            vehicle.PrintVehileInfo();
            car.PrintVehileInfo();

            Car car2 = new Car("Pakettiauto", "Ford", 2015, 35000, 3.3, "Transit", 4);
            car2.PrintVehileInfo();
        }
    }
}
