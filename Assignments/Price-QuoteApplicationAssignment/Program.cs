﻿using System;

namespace Price_QuoteApplicationAssignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below\nPlease enter the package weight:");

            double weight = Convert.ToDouble(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                double length = Convert.ToDouble(Console.ReadLine());

                double total = width + height + length;

                if (total > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    double price = weight * width * height * length / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + price);
                    Console.ReadLine();
                }
            }
        }
    }
        
}
