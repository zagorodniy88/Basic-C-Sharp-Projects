using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee() { FirstName = "OLEKSANDR", LastName = "ZAGORODNII", Id=1};
            employee1.SayName();

            IQuittable employee2 = new Employee() { FirstName = "Joe", LastName = "Dumais", Id = 2 };
            employee2.Quit();

            Employee employee3 = new Employee() { FirstName = "Andrew", LastName = "Jackson", Id = 3 };
            Console.WriteLine(employee1 == employee3);
            Console.WriteLine(employee1 != employee3);

            Employee employee4 = new Employee() { FirstName = "Joe", LastName = "Jefferson", Id = 4 };
            Employee employee5 = new Employee() { FirstName = "Thomas", LastName = "Jefferson", Id = 5 };
            Employee employee6 = new Employee() { FirstName = "Joe", LastName = "Adams", Id = 6 };
            Employee employee7 = new Employee() { FirstName = "Denis", LastName = "Washington", Id = 7 };
            Employee employee8 = new Employee() { FirstName = "William", LastName = "McKinley", Id = 8 };
            Employee employee9 = new Employee() { FirstName = "Joe", LastName = "Wilson", Id = 9 };
            Employee employee10 = new Employee() { FirstName = "Calvin", LastName = "Hoover", Id = 10 };

            List<Employee> employees = new List<Employee> { employee1, employee3, employee4, employee5, employee6, employee7, employee8, employee9, employee10 };
            List<Employee> employeesTemp = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    employeesTemp.Add(employee);
                }
            }
            foreach (Employee employee in employeesTemp)
            {
                Console.WriteLine(employee.FirstName);
            }

            List<Employee> employeesTemp2 = employees.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> employeesTemp3 = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in employeesTemp2)
            {
                Console.WriteLine(employee.FirstName);
            }

            foreach (Employee employee in employeesTemp3)
            {
                Console.WriteLine(employee.Id);
            }
            Console.ReadLine();
        }
    }
}
