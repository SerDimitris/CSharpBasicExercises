/*
 * Write a C# program to create a new array of length containing
 * the middle elements of three arrays (each length 3) of integers.
 * 
 * Test Data:
 * Array1: [1, 2, 5]
 * Array2: [0, 3, 8]
 * Array3: [-1, 0, 2]
 * New array: [2, 3, 0]
 */

namespace MiddleElementsofThreeArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 5 };
            int[] array2 = { 0, 3, 8};
            int[] array3 = { -1, 0, 2 };

            int[] array4 = { array1[array1.Length / 2], array2[array2.Length / 2], array3[array3.Length / 2] };

            Console.WriteLine(string.Join(", ", array4));
        }
    }
}
