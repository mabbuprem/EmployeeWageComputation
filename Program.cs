﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmployeeWage
    {
        static int getworkhrs()
        {
            const int ISPRESENT = 1;
            const int ISPARTTIME = 2;
            const int ISABSENT = 0;

            int workingHours = 8;

            Random random = new Random();
            int employeeCheck = random.Next(0, 3);
            switch (employeeCheck)
            {
                case ISPRESENT:
                    //Console.WriteLine("Employee is present");
                    workingHours = 8;
                    return workingHours;
                    break;
                case ISPARTTIME:
                    //Console.WriteLine("Employee is part-time working");
                    workingHours = 8;
                    return workingHours;
                    break;
                default:
                    //Console.WriteLine("Employee is absent");
                    workingHours = 0;
                    return workingHours;
                    break;
            }
        }
        static void Main(string[] args)
        {
            const int WAGEPERHOUR = 20;
            const int TOTALWORKINGDAYS = 20;
            const int MAXHRSWORKED = 100;


            int totalWorkingHrs = 0;
            int workingDays = 0;

            while (workingDays < TOTALWORKINGDAYS && totalWorkingHrs < MAXHRSWORKED)
            {
                totalWorkingHrs = totalWorkingHrs + getworkhrs();
                workingDays++;
            }
            int employeeWage = totalWorkingHrs * WAGEPERHOUR;
            Console.WriteLine($"Employee earns {employeeWage}");
            Console.ReadLine();

        }
    }
}



