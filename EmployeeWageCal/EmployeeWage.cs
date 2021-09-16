using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCal
{
    class EmployeeWage
    {
        const int IS_PRESENT = 1, WAGE_PER_HOUR = 20, FULL_DAY_HOUR = 8, PART_TIME_HOUR = 4;
        int totalwage = 0;
        public void EmployeeTotalWage()
        {
            Random random = new Random();
            int emplyoeecheck = random.Next(1, 2);
            if (emplyoeecheck == IS_PRESENT)
            {
                this.totalwage = WAGE_PER_HOUR * FULL_DAY_HOUR;
            }
            else
            {
                this.totalwage = WAGE_PER_HOUR * PART_TIME_HOUR;
            }
            Console.WriteLine(totalwage);
        }
    }
}
