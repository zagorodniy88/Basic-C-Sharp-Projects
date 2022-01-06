using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Assignment
{
    internal class Program
    {
        static void Main()
        {
            Employee<string> empl1 = new Employee<string>();
            empl1.Things = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Employee<int> empl2 = new Employee<int>();
            empl2.Things = new List<int> { 110, 54, 89 };

            foreach (string thing in empl1.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in empl2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
