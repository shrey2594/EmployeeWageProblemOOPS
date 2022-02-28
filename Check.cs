using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemOOPS
{
    public class Check
    {
        public static void checkPresentAbsent()
        {
            int isPresent = 1;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == isPresent)
            {
                Console.WriteLine("Employee is presnt.");
            }
            else
            {
                Console.WriteLine("Employee is absent.");
            }
        }
    }
}
