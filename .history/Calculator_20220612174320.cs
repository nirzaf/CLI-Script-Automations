﻿
namespace CLI_Script_Automations
{
    public static class Calculator
    {

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtract(double num1, double num2)
        { 
          return num1-num2;   
        }

        public static void MultiplicationTable(double input)
        {
            for(int i = 0; i < input; i++)
            { 
             }
            
        }

        public static string GetMyFullName(string firstName, string lastName)
        {
            var fullName = "Welcome ! " + firstName + " " + lastName + "...";

            return fullName;
        }

        public static void PrintMyName(string name)
        { 
            Console.WriteLine("Hi your name is :" +  name);    
        }

    }
}