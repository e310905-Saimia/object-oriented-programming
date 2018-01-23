using System;
using System.Collections.Generic;
using System.Text;

namespace TaskVehicle_2
{
    class Car : Vehicle
    {
        protected double _size;
        protected string _model;
        protected int _amountOfDoors;


        public Car(string type, string brand, int yearOfModel, double price, double size, string model, int amountOfDoors) : base(type, brand, yearOfModel, price)
        {
            _size = size;
            _model = model;
            _amountOfDoors = amountOfDoors;
        }

        public override void PrintVehileInfo()
        {
            base.PrintVehileInfo();
            Console.WriteLine($"Koneen koko: {_size:f1} l\n" +
                              $"Merkki: {_model}\n" +
                              $"Ovien lkm: {_amountOfDoors}\n" +
                              $"----------------------------\n");
        }
    }
}
