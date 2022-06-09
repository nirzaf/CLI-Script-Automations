using static Services;
namespace CLI_Script_Automations
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //PrintSum(1, 3);
            Console.WriteLine(ReverseString("FAZRIN"));
            Console.WriteLine(SortString("FAZRIN"));
            Console.WriteLine(IsAnagram("FAZRIN", "NIRZAF"));

            // Let's see a simple C# example to swap two numbers without using third variable.
            int a = 100;
            int b = 200;
            Services.Swap(ref a, ref b);
            Console.WriteLine("After swap: a = {0}, b = {1}", a, b);
        }
    }
}