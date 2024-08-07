using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class MyOwnAutoShop
    {
        public static void main()
        {
            Car Sedan = new Car(100, 20000, "Red");
            Ford f1 = new Ford(120, 50000, "Blue", 2019, 5000, 5);
            Ford f2 = new Ford(110, 50000, "Uwhite", 2020, 5000, 2);
            Truck t1 = new Truck(80, 30000, "Black", 3000);

            // print the sale price
            Console.WriteLine("Sedan sale price: " + Sedan.GetSalePrice());
            Console.WriteLine("Ford f1 sale price: " + f1.GetSalePrice());
            Console.WriteLine("Ford f2 sale price: " + f2.GetSalePrice());
            Console.WriteLine("Truck t1 sale price: " + t1.GetSalePrice());
        }
    }
}
