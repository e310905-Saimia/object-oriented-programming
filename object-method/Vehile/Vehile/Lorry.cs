using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehileXXX;

namespace Vehile
{
    class Lorry:Car
    {
        private double _loadWeight;
        private double _consumptionPerKg;

        public Lorry(string type, string brand, int year, double price, double loadWeight, double consumptionPerKg) : base(type, brand, year, price)
        {
            _loadWeight = loadWeight;
            _consumptionPerKg = consumptionPerKg;
        }

        public Lorry(string type, string brand, int year, double price, double engine, string model, int doors) : base(type, brand, year, price, engine, model, doors)
        {
        }

        public double LoadWeight
        {
            get { return _loadWeight; }
            //set { _loadWeight = value; }
        }

        public double ConsumptionPerKg
        {
            get { return _consumptionPerKg; }
            //set { _consumptionPerKg = value; }
        }

        private double CalculateConsumption()
        {
            return LoadWeight * ConsumptionPerKg;
        }

        public new string PrintData()
        {
            return $"{base.PrintData()}\n" +
                   $"Kuorman paino: {LoadWeight} kg\n" +
                   $"Kulutus/Kg: {ConsumptionPerKg} l/kg\n" +
                   $"Kulutus: {CalculateConsumption()} l\n" +
                   $"*************************\n";
        }


    }
}
