public class Demo
{

    //check if string is a palindrome or not and return boolean value
    public static bool IsPalindrome(string str)
    {
        if (str.Length == 0)
            return true;
        else if (str.Length == 1)
            return true;
        else if (str.Length == 2)
            return str[0] == str[1];
        else
            return str[0] == str[str.Length - 1] && IsPalindrome(str.Substring(1, str.Length - 2));
    }
}
