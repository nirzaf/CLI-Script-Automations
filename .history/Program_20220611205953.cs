using static Services;
namespace CLI_Script_Automations
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            int[] arr =  { 10, 20, 20, 10, 10, 30, 50, 10, 20 };



            
            var output = Algorithms.SockMerchant(9,arr);  
            Console.WriteLine(output);



            // var rotatedArray = Algorithms.LeftRotation(new int[] { 1, 2, 3, 4, 5 }, 2);

            // foreach (var item in rotatedArray)
            // {
            //     Console.Write(item);
            //     Console.Write(" ");
            // }
            
            // Team t1 = new Team("Team1", 10);
            // t1.AddPlayer(5);
            // t1.RemovePlayer(3);
            // Console.WriteLine(t1.noOfPlayers);

            // Subteam t2 = new Subteam("Team2", 10);
            // t2.ChangeTeamName("Team3"); 
            // Console.WriteLine(t2.teamName);

            // var q = new Queue<string>();
            // q.Enqueue("Fazrin");
            // q.Enqueue("Moahmed");
            // q.Enqueue("Farook");

            // q.Dequeue();
            // foreach (var item in q)
            // {
            //     Console.WriteLine(item);
            // }

            // int[] numbers = {7,8,9,10};
            // foreach (var i in numbers)
            // {
            //     Console.WriteLine(i);
            // }
            // var stack = Services.CreateStack(numbers);
            
            // foreach (var i in stack)
            // {
            //     Console.WriteLine(i);
            // }

            //PrintSum(1, 3);
            //Console.WriteLine(ReverseString("FAZRIN"));
            //Console.WriteLine(SortString("FAZRIN"));
            //Console.WriteLine(IsAnagram("FAZRIN", "NIRZAF"));

            //Let's see a simple C# example to swap two numbers without using third variable.
            // int a = 100;
            // int b = 200;
            // Services.Swap(ref a, ref b);
            //Console.WriteLine("After swap: a = {0}, b = {1}", a, b);
            //Check if a number is prime or not.
            //Console.WriteLine(IsPrime(15));
        }
    }
}