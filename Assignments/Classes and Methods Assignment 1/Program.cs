using System;

namespace Classes_and_Methods_Assignment_1
{
    internal class Program
    {
        static void Main()
        {
            Class class1 = new Class();

            Console.WriteLine(class1.subtract(100));

            Console.WriteLine(class1.subtract(100m));

            Console.WriteLine(class1.subtract("100"));

            Console.Read();
        }
    }
}
