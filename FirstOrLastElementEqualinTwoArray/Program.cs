/*
 * Write a C# program to check if the first or the last
 * element of the two arrays (length 1 or more) are equal.
 * 
 * Test Data:
 * Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
 * Array2: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5]
 * 
 * Check if the first element or the last element of the
 * two arrays ( length 1 or more) are equal.
 * 
 * Sample Output: True
 */

namespace FirstOrLastElementEqualinTwoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine(string.Join(", ", array1));

            int[] array2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            Console.WriteLine(string.Join(", ", array2));

            Console.WriteLine(array1[0] == array2[0] || array1[array1.Length - 1].Equals(array2[array2.Length - 1]));
        }
    }
}
