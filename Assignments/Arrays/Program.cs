using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Hello", "Bonjour", "Ola", "Aloha", "Merhaba" };
            Console.WriteLine("enter a number from 0 to 4");
            int i1 = Convert.ToInt32(Console.ReadLine());
            if (i1 < array.Length)
            {
                Console.WriteLine(array[i1]);
            }
            else
            {
                Console.WriteLine("wrong number");
            }

            int[] array2= { 22, 43, 76, 1 };
            Console.WriteLine("enter a number from 0 to 3");
            int i2 = Convert.ToInt32(Console.ReadLine());
            if (i1 < array.Length)
            {
                Console.WriteLine(array2[i2]);
            }
            else
            {
                Console.WriteLine("wrong number");
            }

            List<string> list = new List<string>() { "Au revoir", "Bye", "Adiós", " Auf Wiedersehen", "Arrivederci" };
            
            Console.WriteLine("enter a number from 0 to 4");
            int i3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(list[i3]);
            Console.ReadLine();
        }
    }
}
