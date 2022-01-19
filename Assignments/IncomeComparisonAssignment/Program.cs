using System;

namespace IncomeComparisonAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();
            double rate1 = Convert.ToDouble(hourlyRate1);

            Console.WriteLine("Hours worked per week?");
            string hoursPerWeek1 = Console.ReadLine();
            double hours1 = Convert.ToDouble(hoursPerWeek1);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            double rate2 = Convert.ToDouble(hourlyRate2);

            Console.WriteLine("Hours worked per week?");
            string hoursPerWeek2 = Console.ReadLine();
            double hours2 = Convert.ToDouble(hoursPerWeek2);

            double annualSalary1 = hours1 * rate1 * 52;
            double annualSalary2 = hours2 * rate2 * 52;
            Console.WriteLine("Annual salary of Person 1: \n" + annualSalary1);
            Console.WriteLine("Annual salary of Person 2: \n" + annualSalary2);
            bool result = annualSalary1 > annualSalary2;
            Console.WriteLine("Person 1 makes more money than Person 2?\n" + (result));

            Console.ReadLine();
        }
    }
}
