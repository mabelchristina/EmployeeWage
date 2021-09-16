﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCal
{
    class EmployeeWage
    {
        const int IS_FULLTIME = 0, IS_PARTTIME = 1, WAGE_PER_HOUR = 20, FULL_DAY_HOUR = 8, PART_TIME_HOUR = 4;
        int totalwage = 0, emphours = 0;
        public void EmpWage()
        {
            Random random = new Random();

            int emplyoeecheck = random.Next(0,2);
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
