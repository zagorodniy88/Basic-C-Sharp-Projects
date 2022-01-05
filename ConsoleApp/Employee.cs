using System;


namespace ConsoleApp
{
    internal class Employee: Person, IQuittable
    {
        public int Id { get; set; }

        public void Quit()
        {
            Console.WriteLine("Let's imagine method is implemented");
        }
    }
}
