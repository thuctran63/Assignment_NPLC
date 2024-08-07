using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Car
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

        public double GetSalePrice()
        {
            return RegularPrice;
        }
    }
}
