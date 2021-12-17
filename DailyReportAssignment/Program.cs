﻿using System;

namespace DailyReportAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you in?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            int pageNum = Convert.ToInt32(page);

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            string answer = Console.ReadLine();
            bool isHelpNeeded = Convert.ToBoolean(answer);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveFeedback = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int hoursNum = Convert.ToInt32(hours);

            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");
            Console.Read();
        }
    }
}
