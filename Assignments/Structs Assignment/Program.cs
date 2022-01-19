using System;

namespace Structs_Assignment
{
    internal class Program
    {
        static void Main()
        {
            Number num = new Number();
            num.Amount = 100000000m;
            Console.WriteLine(num.Amount);
            Console.ReadLine();
        }
    }
}
