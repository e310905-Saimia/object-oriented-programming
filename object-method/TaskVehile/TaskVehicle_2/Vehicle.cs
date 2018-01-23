using System;
using System.Collections.Generic;
using System.Text;

namespace TaskVehicle_2
{
    class Vehicle
    {
        protected string _type;
        protected string _brand;
        protected int _year;
        protected double _price;

        public Vehicle(string type, string brand, int yearOfModel, double price)
        {
            _type = type;
            _brand = brand;
            _year = yearOfModel;
            _price = price;
        }

        public virtual void PrintVehileInfo()
        {
            Console.WriteLine($"==================\n" +
                              $"Tyyppi: {_type}\n" +
                              $"Merkki: {_brand}\n" +
                              $"Vuosimalli: {_year}\n" +
                              $"Hinta: {_price}");

        }
    }
}
