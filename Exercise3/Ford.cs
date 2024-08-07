using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Ford : Car
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
