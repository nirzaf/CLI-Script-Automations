using static Services;
namespace CLI_Script_Automations
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
               if (!typeof(Subteam).IsSubclassOf(typeof(Team))) {
                throw new Exception("Subteam class should inherit from Team class");
            }
            
            String str = Console.ReadLine();
            String[] strArr = str.Split();
            string initialName = strArr[0];
            int count = Convert.ToInt32(strArr[1]);
            Subteam teamObj = new Subteam(initialName, count);
            Console.WriteLine("Team " + teamObj.teamName + " created");
            
            str = Console.ReadLine();
            count = Convert.ToInt32(str);
            Console.WriteLine("Current number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
            teamObj.AddPlayer(count);
            Console.WriteLine("New number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
            
            
            str = Console.ReadLine();
            count = Convert.ToInt32(str);
            Console.WriteLine("Current number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
            var res = teamObj.RemovePlayer(count);
            if (res) {
                Console.WriteLine("New number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
            } else {
                Console.WriteLine("Number of players in team " + teamObj.teamName + " remains same");
            }
            
            str = Console.ReadLine();
            teamObj.ChangeTeamName(str);
            Console.WriteLine("Team name of team " + initialName + " changed to " + teamObj.teamName);

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
            int a = 100;
            int b = 200;
            Services.Swap(ref a, ref b);
            //Console.WriteLine("After swap: a = {0}, b = {1}", a, b);
            //Check if a number is prime or not.
            //Console.WriteLine(IsPrime(15));
        }
    }
}