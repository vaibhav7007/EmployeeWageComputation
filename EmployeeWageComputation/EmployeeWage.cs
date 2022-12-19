using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome to EmployeeWageComputation");
            const int IS_PRESENT = 1;
            const int EMP_RATE_PER_HR = 20;
            int empHrs = 0,empWage=0;

            //UC-1 Check employee present or not
            Random random = new Random();
            int employeeInput=random.Next(0,2);

            if (IS_PRESENT == employeeInput)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                //empHrs = 0;
            }

            //UC-2 calculate EmployeeWage
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee Wage is:" + empWage);
            Console.ReadLine();
        }
    }
}
