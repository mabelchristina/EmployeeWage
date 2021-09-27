using System;

namespace EmployeeWageCal
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage apple = new EmployeeWage("Apple", 50, 20, 100);
            EmployeeWage google = new EmployeeWage("Google", 60, 20, 110);
            apple.CalEmployeeWage();
            google.CalEmployeeWage();
        }
    }
}
