using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCal
{
    class EmployeeWage
    {
        const int IS_FULLTIME = 0, IS_PARTTIME = 1, WORKING_DAYS = 20, TOTAL_WORK_HOUR = 100, WAGE_PER_HOUR = 20, FULL_DAY_HOUR = 8, PART_TIME_HOUR = 4 ;

        int work_days = 0, work_hours = 0, emphours = 0, totalwage = 0;
        public void EmployeeWageForMonth()
        {
            Random random = new Random();
            int emplyoeecheck = random.Next(0, 3);
            while (work_days < WORKING_DAYS && work_hours < TOTAL_WORK_HOUR)
            {
                work_days += 1;
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
                Console.WriteLine("employee hours"+emphours);
            }
            work_hours = work_hours + emphours;
            Console.WriteLine(work_days);
            Console.WriteLine(work_hours);
            totalwage = work_hours * WAGE_PER_HOUR;
            Console.WriteLine(totalwage);
        }
    }
}