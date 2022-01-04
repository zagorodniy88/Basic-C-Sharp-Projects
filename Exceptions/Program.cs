using System;
using System.Collections.Generic;

namespace Exceptions
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                List<int> numbers = new List<int>() { 2, 4, 6, 8, 10, 12 };
          
                Console.WriteLine("Enter a whole number");
                int num = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbers)
                {
                    Console.WriteLine(number/num);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Enter a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("It's impossible to divide by zero");
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
            Console.ReadLine();
        }
    }
}
