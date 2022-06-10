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
   
}