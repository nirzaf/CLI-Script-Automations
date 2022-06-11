﻿using static Services;
namespace CLI_Script_Automations
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Queue queue = new Queue<string>();  

            int[] numbers = {7,8,9,10};
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            var stack = Services.CreateStack(numbers);
            
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

            //PrintSum(1, 3);
            //Console.WriteLine(ReverseString("FAZRIN"));
            //Console.WriteLine(SortString("FAZRIN"));
            //Console.WriteLine(IsAnagram("FAZRIN", "NIRZAF"));

            //Let's see a simple C# example to swap two numbers without using third variable.
            int a = 100;
            int b = 200;
            Services.Swap(ref a, ref b);
            //Console.WriteLine("After swap: a = {0}, b = {1}", a, b);
            //Check if a number is prime or not.
            //Console.WriteLine(IsPrime(15));
        }
    }
}