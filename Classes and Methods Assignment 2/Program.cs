using System;


namespace Classes_and_Methods_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            
            Console.WriteLine("Enter one or two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            try
            {
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(test.add(a, b));
            }
            catch (FormatException ex){
                Console.WriteLine(test.add(a));
            }
            finally
            {
                Console.Read();
            }
            
        }
    }
}
