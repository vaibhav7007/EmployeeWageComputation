﻿using System;

namespace EmployeeWagesComputation
{
    internal class EmpWage
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0, empwage = 0;
            Console.WriteLine("Welcome to the employee Wages Computation Practices");
            //UC1 Employee attendance
            Random random = new Random();
            int empInput = random.Next(0, 3);

            switch (empInput)
            {
                case 1:
                    Console.WriteLine("Employee is Full time");
                    empHrs = 8;
                    break;

                case 2:
                    Console.WriteLine("Employee is part time");
                    empHrs = 4;
                    break;

                default:
                    Console.WriteLine("Employee is absent");
                    empHrs = 0;
                    break;
            }

            //Uc2 Calculate daily wages
            empwage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Daily wage is: " + empwage);
            Console.ReadLine();
        }
    }
}