/*
 * Write a C# Sharp program to check whether the average
 * value of the elements of a given array of numbers is
 * a whole number or not.
 * 
 * Sample Output:
 * nums = { 1, 2, 3, 5, 4, 2, 3, 4 }
 * Check the average value of the said array is a whole number or not: True
 * 
 * nums1 = { 2, 4, 2, 6, 4, 8 }
 * Check the average value of the said array is a whole number or not: False
 */

using System.Numerics;

namespace CheckArrayAverageWholeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 5, 4, 2, 3, 4 };
            int[] arr2 = { 2, 4, 2, 6, 4, 8 };

            Console.WriteLine(IsWhole(arr1));
            Console.WriteLine(IsWhole(arr2));
        }

        public static bool IsWhole(int[] array)
        {
            return array.Average() % 1 == 0;
        }
    }
}
