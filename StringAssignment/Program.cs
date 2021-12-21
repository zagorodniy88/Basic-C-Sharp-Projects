using System;

using System.Text;


namespace StringAssignment
{
    internal class Program
    {
        static void Main()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("In a console app, create code that does the following:\n");
            stringBuilder.Append("1. Concatenate three strings.\n");
            stringBuilder.Append("2. Convert a string to uppercase.\n");
            stringBuilder.Append("3. Create a StringBuilder and build a paragraph of text, one sentence at a time.\n");
            Console.WriteLine(stringBuilder.ToString());

            string str1 = "I'm ";
            string str2 = "learning ";
            string str3 = "programming";
            Console.WriteLine(str1 + str2 + str3);
            Console.WriteLine(str3.ToUpper());

            Console.ReadLine();

        }
    }
}
