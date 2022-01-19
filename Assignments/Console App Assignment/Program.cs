using System;
using System.Collections.Generic;

namespace Console_App_Assignment
{
    internal class Program
    {
        static void Main()
        {
            List<string> countries = new List<string>() { "Ukraine", 
                                                        "Canada", 
                                                        "Poland", 
                                                        "France", 
                                                        "USA", 
                                                        "Canada", 
                                                        "Italy",
                                                        "Ukraine",
                                                        "Canada" };
            List<string> tempList = new List<string>();

            foreach (string country in countries)
            {

                if (tempList.Contains(country))
                {
                    Console.WriteLine(country + " has already appeared");
                }
                else
                {
                    Console.WriteLine(country + " hasn't appeared yet");
                    tempList.Add(country);
                }
            }
            Console.ReadLine();

        }
    }
}
