using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCal
{
    class EmployeeWage
    {
        const int IS_PRESENT = 1, WAGE_PER_HOUR = 20, FULL_DAY_HOUR = 8;
        public void WageCal()
        {
            Random random = new Random();
            int emplyoeecheck = random.Next(1, 2);
            if (emplyoeecheck == IS_PRESENT)
            {
                int totalwage = WAGE_PER_HOUR * FULL_DAY_HOUR;
                Console.WriteLine(totalwage);

            }
            else
                Console.WriteLine("Absent");
        }
    }
}
