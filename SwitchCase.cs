using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemOOPS
{
    public class SwitchCase
    {
        public static void switchCase(int number, int wagePerHour, int fullDayHour, int partTimeHour)
        {
            int moneyEarned;
            switch (number)
            {
                case 0:
                    Console.WriteLine("The employee is Absent, hence earned nothing.");
                    break;
                case 1:
                    moneyEarned = wagePerHour * partTimeHour;
                    Console.WriteLine("The employee earned " + moneyEarned + " throughout the day.");
                    break;
                case 2:
                    moneyEarned = wagePerHour * fullDayHour;
                    Console.WriteLine("The employee earned " + moneyEarned + " throughout the day.");
                    break;
                default:
                    Console.WriteLine("Out of context.");
                    break;
            }
        }
    }
}
