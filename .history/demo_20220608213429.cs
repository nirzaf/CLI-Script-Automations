

static bool Palindrome(string input1)
{
    string input = input1.ToLower();
    string input2 = "";
    for (int i = input.Length - 1; i >= 0; i--)
    {
        input2 += input[i];
    }
    if (input == input2)
    {
        return true;
    }
    else
    {
        return false;
    }
}
