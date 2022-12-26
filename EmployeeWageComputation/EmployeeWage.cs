using System;

namespace EmployeeWagesComputation
{
    internal class EmpWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_Hrs = 80;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the employee Wages Computation Practices");
            EmpWage.CalculateWage();
            Console.ReadLine();
        }

        //UC7 Compute Employee Wage using class method
        public static void CalculateWage()
        {
            int empHrs = 0, empwage = 0, totalwage = 0, day = 1, totalHrs = 0;
            Random random = new Random();

            while (day <= MAX_WORKING_DAYS && totalHrs <= MAX_WORKING_Hrs)
            {
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
                totalwage += empwage;
                totalHrs += empHrs;
                day++;
            }
            Console.WriteLine("Total wage for {0} days:{1} and Hrs{2}", (day - 1), totalwage, (totalHrs - empHrs));
            Console.ReadLine();
        }
    }
}