using System;

namespace Exception_Handling_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the year of your birth:");
                int year = Convert.ToInt32(Console.ReadLine());
                if (year < 0)
                {
                    throw new NegativeNumberException();
                }
                if (year == 0)
                {
                    throw new ZeroException();
                }
                Console.WriteLine(year);

            }
            catch (NegativeNumberException)
            {
                Console.WriteLine("You entered negative number");
            }
            catch (ZeroException)
            {
                Console.WriteLine("You entered 0");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured. Please contact your System Administrator");
            }
            Console.ReadLine();
        }
    }
}
