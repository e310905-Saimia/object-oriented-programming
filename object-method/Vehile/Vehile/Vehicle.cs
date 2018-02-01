using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehileXXX
{
    class Vehicle
    {
        protected string Type;
        protected string Brand;
        protected int Year;
        protected double Price;


        public Vehicle(string type, string brand, int year, double price)
        {
            Type = type;
            Brand = brand;
            Year = year;
            Price = price;
        }

        public virtual bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public virtual string PrintData()
        {
            return $"-------------\n" +
                   $"Tyyppi: {Type}\n" +
                   $"Merkki: {Brand}\n" +
                   $"Vuosimalli: {Year}\n" +
                   $"Hinta: {Price}\n" +
                   $"==============\n";
        }

        public override string ToString()
        {
            return PrintData();
        }
    }

    class Car : Vehicle
    {
        //Fields
        protected double Engine;
        protected string Model;
        protected int Doors;

       public Car(string type, string brand, int year, double price, double engine, string model, int doors) : base(type, brand, year, price)
        {
            Engine = engine;
            Model = model;
            Doors = doors;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string PrintData()
        {
            return $"{base.PrintData()}\n" +
                   $"Moottori: {Engine}\n" +
                   $"Malli: {Model}\n" +
                   $"Ovien määrä: {Doors}\n" +
                   $"xxxxxxxxxxxxxxxxx\n";
        }

        public override string ToString()
        {
            return PrintData();
        }
    }
}
