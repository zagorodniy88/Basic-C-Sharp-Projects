﻿using System;

//Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer. The methods should do some math operation on the received parameter. Put this class in a separate .cs file in the application.
//In the Main() program, ask the user what number they want to do the math operations on.
//Call each method in turn, passing the user input to the method. Display the returned integer to the screen.
namespace Method_Assignment
{
    internal class Task1
    {
        public int add (int a, int b){
        return a + b;
        }

        public int subtract(int a, int b)
        {
            return a - b;
        }

        public int multiply(int a, int b)
        {
            return a * b;
        }
    }
}
