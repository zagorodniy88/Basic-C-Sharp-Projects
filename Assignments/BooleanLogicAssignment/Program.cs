using System;

namespace BooleanLogicAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageInt = Convert.ToInt32(age);
            Console.WriteLine("Have you ever had a DUI?");
            string answer = Console.ReadLine();
            bool trueOrFalse = Convert.ToBoolean(answer);
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int ticketsInt = Convert.ToInt32(tickets);
            Console.WriteLine("Qualified?");

            bool result = ageInt > 15 && (trueOrFalse != true) && (ticketsInt < 3);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
