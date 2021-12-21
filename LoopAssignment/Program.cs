using System;

namespace LoopAssignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter something to the program. Or type 'stop' to quit.");

            string input = "";

            while (input != "stop")
            {
                input = Console.ReadLine();
                Console.WriteLine("You entered: " + input);
               
            }

            Console.WriteLine("Enter something again to the program. Or type 'stop' to quit.");

            do
            {
                input = Console.ReadLine();
                Console.WriteLine("You entered: " + input);
            }
            while (input != "stop");
        }
    }
}
