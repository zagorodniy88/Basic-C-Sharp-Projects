﻿using System;


namespace Abstract_Classes_Assignment
{
    internal class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }
    }
}
