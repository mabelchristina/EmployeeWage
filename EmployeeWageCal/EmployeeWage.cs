using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCal
{
    class EmployeeWage
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        private string companyName;
        int employeeRatePerHour, numofworkdays, maxhourpermonth, totalEmpWage;
        public EmployeeWage(string companyName, int employeeRatePerHour, int numberOfWorkingDays, int maxHrsInMonth)
        {
            this.companyName = companyName;
            this.employeeRatePerHour = employeeRatePerHour;
            this.numofworkdays = numberOfWorkingDays;
            this.maxhourpermonth = maxHrsInMonth;
        }
        public void CalEmployeeWage()
        {
            int employeeHours = 0;
            int totalEmployeeHours = 0;
            int totalWorkingDays = 0;
            Random random = new Random();
            int emplyoeecheck = random.Next(0, 3);
            while (totalEmployeeHours <= maxhourpermonth && totalWorkingDays < numofworkdays)
            {
                totalWorkingDays += 1;
                switch (emplyoeecheck)
                {
                    case IS_FULL_TIME:
                        employeeHours += 8;
                        break;
                    case IS_PART_TIME:
                        employeeHours += 4;
                        break;
                    default:
                        employeeHours += 0;
                        break;
                }
                Console.WriteLine("employee hours" + employeeHours);
            }
            int totalEmpWage = totalEmployeeHours + employeeRatePerHour;
            Console.WriteLine(" employee wage for company " + companyName + " is " + totalEmpWage);
        }
    }
}