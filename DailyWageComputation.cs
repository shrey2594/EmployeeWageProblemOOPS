using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemOOPS
{
    public class DailyWageComputation
    {
        public static void CalculateDailyWage()
        {
            int wagePerHour = 20;
            int fullDayHour = 8;
            int moneyEarned;
            if (Check.checkPresentAbsent() == true)
            {
                moneyEarned = wagePerHour * fullDayHour;
                Console.WriteLine("The employee earned " + moneyEarned + " throughout the day.");
            }
            else
            {
                Console.WriteLine("The employee is Absent, hence earned nothing.");
            }
        }
    }
}
