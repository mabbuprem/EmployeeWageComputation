﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class UC2_EmployeeDailyWage
    {
        public static void GetAttendence()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empcheck = random.Next(0.2);
            if (empcheck == IS_FULL_TIME)

                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }

        public static void PartTimeEmpWge()
        {
            //Constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PART_TIME)
                empHrs = 4;
            else if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            else
                empHrs = 0;
            empWage = empHrs;
          EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: + empWage");
            Console.ReadKey();
        }

    }

}
    

