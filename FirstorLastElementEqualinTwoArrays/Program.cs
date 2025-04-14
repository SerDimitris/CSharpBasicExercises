/*
 * Write a C# program that checks if the first element and the last
 * element of an array of integers are equal. The array length is 1 or more.
 * 
 * Test Data:
 * Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
 * Sample Output: True
 */

namespace FirstorLastElementEqualinArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine(CheckArray(array));
        }

        public static bool CheckArray(int[] arr)
        {
            return arr[0] == arr[arr.Length - 1];
        }
    }
}
