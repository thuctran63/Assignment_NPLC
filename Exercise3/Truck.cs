using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Truck : Car
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
}
