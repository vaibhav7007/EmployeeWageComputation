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
            const int IS_PRESENT=1;
            Console.WriteLine("Welcome to EmployeeWageComputation");
            //UC-1 Check employee present or not
            Random random = new Random();
            int employeeInput=random.Next(0,2);

            if (IS_PRESENT == employeeInput)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
            Console.ReadLine();
        }
    }
}
