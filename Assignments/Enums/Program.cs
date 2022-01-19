using System;

namespace Enums
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter the current day of the week: ");
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), Console.ReadLine(), true);
                Console.WriteLine(currentDay);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
