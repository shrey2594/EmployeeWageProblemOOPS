using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemOOPS
{
    public class SwitchCase
    {
        public static int switchCase(int number, int wagePerHour, int fullDayHour, int partTimeHour)
        {
            int moneyEarned;
            switch (number)
            {
                case 0:
                    return 0;
                case 1:
                    moneyEarned = wagePerHour * partTimeHour;
                    return moneyEarned;
                case 2:
                    moneyEarned = wagePerHour * fullDayHour;
                    return moneyEarned;
                default:
                    return 0;
            }
        }
    }
}
