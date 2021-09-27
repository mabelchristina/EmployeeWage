using System;

namespace EmployeeWageCal
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage empWageBuilder = new EmployeeWage();
            empWageBuilder.addComapnyEmpWage("Apple", 20, 2, 10);
            empWageBuilder.addComapnyEmpWage("Google", 10, 4, 20);
            empWageBuilder.computeEmpWage();
        }
    }
}
