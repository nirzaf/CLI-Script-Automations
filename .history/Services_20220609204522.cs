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
    public static string ReverseString(string str)
    {
        string reversed = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversed += str[i];
        }
        return reversed;
    }

    // Sort an string input alphabetically.
    public static string SortString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Sort(charArray);
        return new string(charArray);
    }

    //Check two strings are anagram or not.
     
}