using System;


namespace Class_Method_Assignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            Test.DivideBy2(num);

            Console.WriteLine("Enter one more number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int output = 0;
            Test.DivideBy2(num2, out output);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
