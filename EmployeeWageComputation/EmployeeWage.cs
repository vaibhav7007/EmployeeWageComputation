using System;

namespace EmployeeWagesComputation
{
    internal class EmpWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the employee Wages Computation Practices");
            //UC8 Computing Employee Wage for multiple companies
            CalculateWage("Bridgelabz", 30, 25, 80);
            CalculateWage("Microsoft", 40, 30, 70);
            CalculateWage("IBM", 35, 29, 80);
            Console.ReadLine();
        }

        //UC7 Compute Employee Wage using class method
        public static void CalculateWage(string Company, int emp_rate_per_Hr, int max_Working_days, int max_Working_Hrs)
        {
            int empHrs = 0, empwage = 0, totalwage = 0, day = 1, totalHrs = 0;
            Random random = new Random();

            while (day <= max_Working_days && totalHrs <= max_Working_Hrs)
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
                empwage = emp_rate_per_Hr * empHrs;
                totalwage += empwage;
                totalHrs += empHrs;
                day++;
            }
            Console.WriteLine("Total wage for{3} {0} days:{1} and Hrs{2}", totalwage, (day - 1), (totalHrs - empHrs), Company);
            Console.ReadLine();
        }
    }
}