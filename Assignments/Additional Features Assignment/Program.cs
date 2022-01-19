using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string department = "IT";

            var emp1 = new Employee(2, "Nikita");
            var emp2 = new Employee("Natasha");

            Console.WriteLine(emp1.Name + " from " + department + " department");
            Console.Read();
        }
    }
}
