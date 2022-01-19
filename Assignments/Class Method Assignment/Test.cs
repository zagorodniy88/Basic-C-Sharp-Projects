using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    public static class Test
    {
        public static void DivideBy2(int a)
        {
            Console.WriteLine(a / 2);
        }

        public static void DivideBy2(int a, out int output)
        {
            output = a / 2;
        }
    }
}
