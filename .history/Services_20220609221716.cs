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
    public static bool IsAnagram(string str1, string str2)
    {
        if (str1.Length != str2.Length)
        {
            return false;
        }
        else
        {
            char[] charArray1 = str1.ToCharArray();
            char[] charArray2 = str2.ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);
            return new string(charArray1) == new string(charArray2);
        }
    } 

    // Swap two numbers without using third variable.
    public static void Swap(ref int a, ref int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }

    
}