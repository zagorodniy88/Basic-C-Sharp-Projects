using System;

namespace MathOperationAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int result1 = number * 50;

            Console.WriteLine(result1);

            int result2 = number + 25;

            Console.WriteLine(result2);

            double result3 = number / 12.5;

            Console.WriteLine(result3);

            bool isGreater = number > 50;

            Console.WriteLine(isGreater);

            int result4 = number % 7;

            Console.WriteLine(result4);

            Console.ReadLine();
        }
    }
}
