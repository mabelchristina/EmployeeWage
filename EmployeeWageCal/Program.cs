using System;

namespace EmployeeWageCal
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.EmployeeWageForMonth("starBazaar",20,1,22);
            employeeWage.EmployeeWageForMonth("BigBazaar", 10, 3, 21);
            Console.ReadLine();
        }
    }
}
