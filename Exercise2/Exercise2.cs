using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Exercise2
    {
        public static void main()
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter first name: ");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            employee.LastName = Console.ReadLine();
            Console.WriteLine("Enter monthly salary: ");
            employee.MonthlySalary = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Information employee: ");
            Console.WriteLine(employee.ToString());



        }
    }
}
