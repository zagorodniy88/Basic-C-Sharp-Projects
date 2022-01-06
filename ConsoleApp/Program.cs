using System;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee() { FirstName = "OLEKSANDR", LastName = "ZAGORODNII", Id=1};
            employee1.SayName();

            IQuittable employee2 = new Employee();
            employee2.Quit();

            Employee employee3 = new Employee();
            employee3.Id = 2;
            Console.WriteLine(employee1 == employee3);
            Console.WriteLine(employee1 != employee3);
            Console.Read();
        }
    }
}
