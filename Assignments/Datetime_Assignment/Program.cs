using System;

namespace Datetime_Assignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter the number:");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddHours(hours));
            Console.Read();
        }
    }
}
