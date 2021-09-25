using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCal
{
    class EmployeeWage
    {
        const int IS_FULLTIME = 0, IS_PARTTIME = 1;

        int totalworkdays=0, emphours = 0, totalEmpHours = 0;
        public void EmployeeWageForMonth(string company,int wageperhour,int numofworkdays,int maxhourpermonth)
        {

            Random random = new Random();
            int emplyoeecheck = random.Next(0, 3);
            while (totalEmpHours <= maxhourpermonth && totalworkdays < numofworkdays)
            {
                totalworkdays += 1;
                switch (emplyoeecheck)
                {
                    case IS_FULLTIME:
                        emphours += 8;
                        break;
                    case IS_PARTTIME:
                        emphours += 4;
                        break;
                    default:
                        emphours += 0;
                        break;
                }
                Console.WriteLine("employee hours"+emphours);
            }
            int totalEmpWage = totalEmpHours + wageperhour;
            Console.WriteLine("total employee wage for company" + company + "is" + totalEmpWage);
        }
    }
}