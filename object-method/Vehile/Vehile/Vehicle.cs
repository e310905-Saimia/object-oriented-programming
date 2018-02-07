using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehileXXX
{
    abstract class Vehicle
    {
        protected string Type;
        private string _brand;
        protected int Year;
        protected double Price;

        public string Brand { get => _brand; set => _brand = value; }

        public Vehicle(string type, string brand, int year, double price)
        {
            Type = type;
            Brand = brand;
            Year = year;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            if (Year >= ((Vehicle) obj).Year)
                return false;
            else
                return true;
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
        private double _engine;
        protected string Model;
        protected int Doors;

        //Constructor
        // default contructor added for abstract class
        public Car(string type, string brand, int year, double price) : base(type, brand, year, price)
        {
        }

        public Car(string type, string brand, int year, double price, double engine, string model, int doors) : base(type, brand, year, price)
        {
            Engine = engine;
            Model = model;
            Doors = doors;
        }

        

        //Properties
        public double Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }

        //Methods
        public override bool Equals(object obj)
        {
            if (Engine >= ((Car) obj).Engine)
                return true;
            else            
                return false;            
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
