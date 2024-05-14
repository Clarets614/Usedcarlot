using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLot
{
    public class Car
    {
        //properties
        public string make {  get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public decimal price { get; set; }
        public int inventory { get; set; }


        //constructor 
        public Car (string _make, string _model, int _year, decimal _price, int _inventory)
        {
            make = _make;
            model = _model;
            year = _year;
            price = _price;
            inventory = _inventory;
        }

        public Car()
        {
            make = "";
            model = "";
            year = -1;
            price = -1;
        }

        public override string ToString()
        {
            return $"{make} {model} {year} ${price}";
        }

    }
}
