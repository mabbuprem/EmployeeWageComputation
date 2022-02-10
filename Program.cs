
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculator
{
    class Program
    {
        public static void Main(string[] args)

        {
            Console.WriteLine($"Employee Wage Calculator");
            int workingHr = 1;
            int perHrSalary = 20;

            Random random = new Random();
            int present = (random.Next(2));

            switch (present)
            {

                case 0:
                    Console.WriteLine("Employee is absent");
                    workingHr = 0;
                    break;

                case 1:
                    Console.WriteLine("Employee is present");
                    workingHr = 8;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            int salary = perHrSalary * workingHr;
            Console.WriteLine($"Salary {salary}");

        }
    }
}

    

