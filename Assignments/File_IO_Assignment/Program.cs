using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");

            File.WriteAllText(@"C:\Users\***\File IO Assignment\log.txt", Console.ReadLine());

            Console.WriteLine(File.ReadAllText(@"C:\Users\***\File IO Assignment\log.txt"));

            Console.ReadLine();
        }
    }
}
