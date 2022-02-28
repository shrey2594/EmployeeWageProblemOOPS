using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemOOPS
{
    public class WageCondition
    {
        public static bool WageCalculationCondition(int totalHour, int dayCount)
        {
            int workDayPerMonth = 20;
            int hourCheck = 100;
            if (totalHour <= hourCheck && dayCount <= workDayPerMonth)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
