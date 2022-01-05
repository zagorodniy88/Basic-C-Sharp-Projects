using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { firstName = "OLEKSANDR", lastName = "ZAGORODNII" };
            emp.SayName();
            Console.Read();
        }
    }
}
