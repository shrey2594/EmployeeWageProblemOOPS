using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblemOOPS
{
    public class MonthlyWage
    {
        public static void CalculateMonthlyWage(int workDayPerMonth, int wagePerHour, int fullDayHour, int partTimeHour)
        {
            int Total_Amount = 0;
            for (int i = 0; i < workDayPerMonth; i++)
            {
                int value = Convert.ToInt32(Check.checkPresentAbsent());
                if (value != 0)
                { value += Convert.ToInt32(CheckPartTime.PartTime()); }
                Total_Amount += SwitchCase.switchCase(value, wagePerHour, fullDayHour, partTimeHour);
            }
            Console.WriteLine("The employee got a salary of " + Total_Amount + " Rupees.");
        }
    }
}
