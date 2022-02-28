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
                int partTimeHour = 4;
                int moneyEarned;
                if (Check.checkPresentAbsent() == true)
                {
                    if (CheckPartTime.PartTime() == true)
                    {
                        moneyEarned = wagePerHour * partTimeHour;
                    }
                    else
                    {
                        moneyEarned = wagePerHour * fullDayHour;
                    }
                    Console.WriteLine("The employee earned " + moneyEarned + " throughout the day.");
                }
                else
                {
                    Console.WriteLine("The employee is Absent, hence earned nothing.");
                }
            }
    }
}
