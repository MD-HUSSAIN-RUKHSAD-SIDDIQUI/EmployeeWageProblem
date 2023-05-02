using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class EmpAttendance
    {
        public static void Check()
        {
            int isPresent = 1;
            Random random = new Random();
            int Check = random.Next(2);
            if (Check == isPresent)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
        }
    }
}
