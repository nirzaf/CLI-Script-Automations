
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

        //get the input from the user and print the multiplication table of that number up to 10
        public static void PrintMultiplicationTable(int number)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + (number * i));
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
