using System;
using VehileXXX;

namespace Vehile
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("Mopo", "Solifer", 1960, 1500);
            Car c1 = new Car("Auto", "Audi", 2015, 26000,3.3,"Quatro",4);

            Console.WriteLine(v1.PrintData());
            Console.WriteLine(c1.PrintData());

            Console.WriteLine(v1.ToString());
            Console.WriteLine(c1.ToString());

        }
    }
}
