public static class Algorithms
{
   // A left rotation operation on an array shifts each of the array's elements 1 unit to the left.
   // For example, if 2 left rotations are performed on array {1,2,3,4,5} , then the array would become {3,4,5,1,2} .
   // Given an array a of n integers and a number, d, perform d left rotations on the array. 
   // Return the updated array to be printed as a single line of space-separated integers.

    public static int[] LeftRotation(int[] a, int d)
    {
        int[] result = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            result[(i + d) % a.Length] = a[i];
        }
        return result;
    }
    /* There is a large pile of socks that must be paired by color. Given an array of integers representing the color
    of each sock, determine how many pairs of socks with matching colors there are.
    Example
    n = 7
    ar = [1, 2, 1, 2, 1, 3, 2]
    There is one pair of color 1 and one of color 2. There are three odd socks left, one of each color. The number
    of pairs is 2.
    Function Description
    Complete the sockMerchant function in the editor below.
    sockMerchant has the following parameter(s):
    ⚫ int n: the number of socks in the pile
    ⚫ int ar[n]: the colors of each sock
    Returns
    ⚫int: the number of pairs
    Input Format
    The first line contains an integer n, the number of socks represented in ar.
    The second line contains n space-separated integers, ar[i], the colors of the socks in the pile.
    Constraints
    • 1 ≤ n ≤ 100
    • 1 ≤ ar[i] < 100 where 0 < i < n
    */

    public static int SockMerchant(int n, int[] ar)
    {
       int[] ar1 = ar.ToArray();
       int i, np=0;
       for(i=0;i<n;i++)
       {
           for(int j=i+1;j<n;j++)
           {
               if(ar1[i] != 101 && ar[i] == ar1[j])
               {
                   np++;
                   ar1[i]=101;
                   ar1[j]=101;
               }
           }
       }
        return np;
    }
}