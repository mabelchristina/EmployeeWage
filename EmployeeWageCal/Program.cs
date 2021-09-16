using System;

namespace EmployeeWageCal
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.EmployeeWageForMonth();
            Console.ReadLine();
        }
    }
}
