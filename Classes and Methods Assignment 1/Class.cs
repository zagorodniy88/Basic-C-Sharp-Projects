using System;


namespace Classes_and_Methods_Assignment_1
{
    internal class Class
    {
        public int subtract(int num)
        {
            return num - 1;
        }
        public int subtract(decimal num)
        {
            return Convert.ToInt32(num) - 10;
        }
        public int subtract(string num)
        {
            return Convert.ToInt32(num) - 100;
        }
    }
}
