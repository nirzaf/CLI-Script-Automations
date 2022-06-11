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

    // Check if a number is prime or not.
    public static bool IsPrime(int num)
    {
        if (num == 1)
        {
            return false;
        }
        else
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

    /* Find the previous smaller element for each array element
    In other words, for each element A[i] in the array A, 
    find an element A[j] such that j < i and A[j] < A[i] and value of j should be as maximum as possible. 
    If the previous smaller element doesn't in the array for any element, consider it -1. */
    public static int[] PreviousSmallerElement(int[] numbers)
    {
        int[] previousSmallerElement = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            int previousSmaller = -1;
            for (int j = 0; j < i; j++)
            {
                if (numbers[j] < numbers[i])
                {
                    previousSmaller = numbers[j];
                    break;
                }
            }
            previousSmallerElement[i] = previousSmaller;
        }
        return previousSmallerElement;
    }

    // Create a method to take int array as input and return stack of integers.
    public static Stack<int> CreateStack(int[] numbers)
    {
        var stack = new Stack<int>();
        foreach (int i in numbers)
        {
            stack.Push(i);
        }
        return stack;
    } 

    // Create a method to take array of integers 
}