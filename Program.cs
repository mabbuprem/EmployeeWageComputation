
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class EmpWageUsingSwitch
    {
        public static void GetAttendence()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }

        public static void EmpWage()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
                //variable
                int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                empHrs = 8;
                //else
                //emHrs = 0;
                empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: " + empWage);
            Console.ReadKey();

        }

        public static void partTimeEmployeeWage()
        {
            //constant
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            //variable
            int empHrs = 0;
            int empWage = 0;
            Random rand = new Random();
            int empCheck = rand.Next(0, 2);
            if (empCheck == IS_PART_TIME)
                empHrs = 4;
            else if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            else
                empHrs = 0;
            empWage = empHrs *
        EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: + empWage");
            Console.ReadKey();


        }
        internal class EmployeeWage
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 0;
            const int IS_PRESENT = 1;
            const int IS_ABSENT = 0;
            const int EMP_PER_HOUR = 20;


            public void GetDailyWage()
            {
                int dailyWage = 0;
                int dailyHours = 0;
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        dailyHours = 8;
                        break;
                    case IS_PART_TIME:
                        dailyHours = 4;
                        break;
                    default:
                        dailyHours = 0;
                        break;

                }
                dailyWage = dailyHours * RATE_PER_HOUR;
                Console.WriteLine("Daily Wage: " + dailyWage);
            }
        }
    }
}
      
    

