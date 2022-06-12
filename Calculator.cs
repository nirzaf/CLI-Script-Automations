using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static string GetMyFullName(string firstName, string lastName)
        {
            return "Welcome ! " + firstName + " " + lastName + "...";
        }

    }
}
