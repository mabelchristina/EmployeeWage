using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCal
{
    class EmployeeWage
    {
        const int IS_PRESENT = 1;
        public void Attendance()
        {
            Random random = new Random();
            int emplyoeecheck = random.Next(0, 2);
            if (emplyoeecheck == IS_PRESENT)
                Console.WriteLine("Present");
            else
                Console.WriteLine("Absent");
        }
    }
}
