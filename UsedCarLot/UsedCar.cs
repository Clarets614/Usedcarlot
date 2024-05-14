using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLot
{
    public class UsedCar : Car
    {
        public double Mileage { get; set; }

        public UsedCar(string _make, string _model, int _year, decimal _price, int _inventory, double _mileage)
            : base(_make, _model, _year, _price, _inventory)
        { 
            Mileage = _mileage;
        }

        public override string ToString()
        {
            return $"{make} {model} {year} {Mileage} miles ${price}";
        }
    }


}
