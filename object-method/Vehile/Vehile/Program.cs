using System;
using VehileXXX;

namespace Vehile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle v1 = new Vehicle("Mopo", "Solifer", 1960, 1500); // Ei toimi, koska Vehicle muutettiin abstraktiksi luokaksi
            Vehicle v1 = new Car("Mopo", "Solifer", 1960, 1500);
            
            Car c1 = new Car("Auto", "Audi", 2015, 26000,3.3,"Quatro",4);

            Console.WriteLine(v1.PrintData());
            Console.WriteLine(c1.PrintData());

            Console.WriteLine(v1.ToString());
            Console.WriteLine(c1.ToString());


            //Vehicle v2 = new Vehicle("Polkupyörä", "Jopo", 2000, 500); // Ei toimi, koska Vehicle muutettiin abstraktiksi luokaksi
            Vehicle v2 = new Car("Polkupyörä", "Jopo", 2000, 500);
            Console.WriteLine(v2.ToString());

            Console.WriteLine($"Onko {v1.Brand} vanhempi kuin {v2.Brand}? " +
                              $"Vastaus: {v1.Equals(v2)}");

            Car c2 = new Car("Auto", "VW", 2017, 36000, 3.8, "Transporter", 5);
            Console.WriteLine(c2.ToString());
            Console.WriteLine($"Onko {c1.Brand} moottori suurempi kuin {c2.Brand}? " +
                              $"Vastaus: {c1.Equals(c2)}");
            Console.WriteLine($"Onko {c2.Brand} moottori suurempi kuin {c1.Brand}? " +
                              $"Vastaus: {c2.Equals(c1)}");

            Lorry lorry_1 = new Lorry("Kuorma-auto", "Volvo",2000,45000,5000,0.2);
            Console.WriteLine($"{lorry_1.PrintData()}");

            Car c3 = (Car) lorry_1;
            Console.WriteLine(c3.PrintData());


        }
    }
}
