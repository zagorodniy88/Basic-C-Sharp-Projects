using System;


namespace Method_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();

            Console.WriteLine("Type two numbers that you want to do the math operations on. What is the first one?");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the seconde one?");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(task1.add(num1, num2));
            Console.WriteLine(task1.subtract(num1, num2));
            Console.WriteLine(task1.multiply(num1, num2));
            Console.ReadLine();
        }
    }
}
