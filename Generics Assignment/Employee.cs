using System;
using System.Collections.Generic;

namespace Generics_Assignment
{
    internal class Employee <T>
    {
        public int Id { get; set; }
        public List<T> Things { get; set; }
    }
}
