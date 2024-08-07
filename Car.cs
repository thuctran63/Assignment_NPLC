using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Car
    {
        public decimal Speed { get; set; }
        public double RegularPrice { get; set; }
        public string Color { get; set; }

        public Car(decimal speed, double regularPrice, string color)
        {
            Speed = speed;
            RegularPrice = regularPrice;
            Color = color;
        }

        public double GetSalePrice() {
            return RegularPrice;
        }


    }

    class Truck : Car
    {
        public int Weight { get; set; }

        public Truck(decimal speed, double regularPrice, string color, int weight) : base(speed, regularPrice, color)
        {
            Weight = weight;
        }

        public new double GetSalePrice()
        {
            if (Weight > 2000)
            {
                return RegularPrice * 0.9;
            }
            else
            {
                return RegularPrice * 0.8;
            }
        }
    }

    class Ford : Car
    {
        public int Year { get; set; }
        public int ManufacturerDiscount { get; set; }
        public int Length { get; set; }

        public Ford(decimal speed, double regularPrice, string color, int year, int manufacturerDiscount, int length) : base(speed, regularPrice, color)
        {
            Year = year;
            ManufacturerDiscount = manufacturerDiscount;
            Length = length;
        }

        public new double GetSalePrice()
        {
            return this.Length > 20 ? this.RegularPrice * 0.95 : this.RegularPrice * 0.9;
        }
    }
}
