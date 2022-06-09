public static class Services
{
   public static void PrintSum(int a, int b)
    {
        int sum = 0;
        for (int i = a; i <= b; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }

    // Create a method that takes a string and returns the string in reversed order.
}