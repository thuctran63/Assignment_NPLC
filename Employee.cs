using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Employee
    {
        public string? FirstName { get;set; }
        public string? LastName { get; set;  }
        private double _MonthlySalary;

        public double MonthlySalary
        {
            get { return _MonthlySalary; }
            set
            {
                if (value > 0)
                {
                    _MonthlySalary = value;
                }
                else                 {
                    _MonthlySalary = 0.0;
                }
            }
        }

        public Employee(string? firstName, string? lastName, double monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
        }

        public Employee() { }

       
    }
}
