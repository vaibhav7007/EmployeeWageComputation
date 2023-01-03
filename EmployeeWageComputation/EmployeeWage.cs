using System;

namespace EmployeeWagesComputation
{
    internal class EmpWage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the employee Wages Computation Practices");

            EmpwageBuilderObject bridgelabz = new EmpwageBuilderObject("Bridgelabz", 30, 25, 80);
            EmpwageBuilderObject microsoft = new EmpwageBuilderObject("Microsoft", 40, 30, 70);
            EmpwageBuilderObject ibm = new EmpwageBuilderObject("IBM", 35, 29, 80);
            bridgelabz.CalculateWage();
            Console.WriteLine(bridgelabz.ToString());
            Console.WriteLine(microsoft.ToString());
            Console.WriteLine(ibm.ToString());
            microsoft.CalculateWage();
            ibm.CalculateWage();
            Console.ReadLine();
        }
        //UC9 Total wage for each company
        public class EmpwageBuilderObject
        {
            public const int FULL_TIME = 1;
            public const int PART_TIME = 2;

            private string Company;
            private int emp_rate_per_Hr;
            private int max_Working_days;  //numofworkingdays
            private int max_Working_Hrs;  //maxhourspermonth
            private int totalEmpWage;
            //UC9 Compute employee wage and save total wage by company
            public EmpwageBuilderObject(string Company, int emp_rate_per_Hr, int max_Working_days, int max_Working_Hrs)
            {
                this.Company = Company;
                this.emp_rate_per_Hr = emp_rate_per_Hr;
                this.max_Working_days = max_Working_days;
                this.max_Working_Hrs = max_Working_Hrs;
            }
            //UC7 Compute Employee Wage using class method
            public void CalculateWage()
            {
                int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

                while (totalEmpHrs < this.max_Working_Hrs && totalWorkingDays < this.max_Working_days)
                {
                    totalWorkingDays++;
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
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Day:" + totalWorkingDays + "Emp Hrs: " + empHrs);
                }
                int totalEmpWage = totalEmpHrs * this.emp_rate_per_Hr;
                Console.WriteLine("Total wage for :" + Company + "is:" + totalEmpWage);
            }
            public string toString()
            {
                return "Total wage for company:" + this.Company + "is :" + this.totalEmpWage;
            }
        }
    }
}