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
            int final = Convert.ToInt32(Check.checkPresentAbsent());
            if (final != 0)
            { final += Convert.ToInt32(CheckPartTime.PartTime()); }
            SwitchCase.switchCase(final, wagePerHour, fullDayHour, partTimeHour);
        }
    }
}
