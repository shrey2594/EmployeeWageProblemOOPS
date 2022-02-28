using System;

namespace EmployeeWageProblemOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program.");
            DailyWageComputation dailyWageComputation = new DailyWageComputation();
            dailyWageComputation.CalculateDailyWage();
        }
    }
}
