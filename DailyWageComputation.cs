using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemOOPS
{
    public class DailyWageComputation
    {
        public void CalculateDailyWage()
        {
            int wagePerHour = 20;
            int fullDayHour = 8;
            int partTimeHour = 4;
            int workDayPerMonth = 20;
            MonthlyWage monthlyWage = new MonthlyWage();
            monthlyWage.CalculateMonthlyWage(workDayPerMonth, wagePerHour, fullDayHour, partTimeHour);
        }
    }
}
