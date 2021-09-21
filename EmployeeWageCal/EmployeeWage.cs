using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCal
{
    class EmployeeWage
    {
        const int IS_FULLTIME = 0, IS_PARTTIME = 1, WAGE_PER_HOUR = 20, FULL_DAY_HOUR = 8, PART_TIME_HOUR = 4, WORKDAY_PER_MONTH=20;
        int totalwage = 0, emphours = 0;
        public void EmployeeHours()
        {
            Random random = new Random();
            for (int i = 0; i < WORKDAY_PER_MONTH; i++)
            {
                int emplyoeecheck = random.Next(1, 3);
                switch (emplyoeecheck)
                {
                    case IS_FULLTIME:
                        emphours += FULL_DAY_HOUR;
                        break;
                    case IS_PARTTIME:
                        emphours += PART_TIME_HOUR;
                        break;
                    default:
                        emphours += 0;
                        break;
                }
                this.totalwage = WAGE_PER_HOUR * emphours;
                Console.WriteLine(totalwage);
            }
        }
    }
}
