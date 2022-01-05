using System;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee() { FirstName = "OLEKSANDR", LastName = "ZAGORODNII"};
            employee1.SayName();

            IQuittable employee2 = new Employee();
            employee2.Quit();
            Console.Read();
        }
    }
}
