using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features_Assignment
{
    public class Employee
    {
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Employee(string name) : this(0, name)
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
