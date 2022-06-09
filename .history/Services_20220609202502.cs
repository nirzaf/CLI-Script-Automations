public class Services
{
    public void PrintOddNumbers(int a, int b)
    {
        for (int i = a; i <= b; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}