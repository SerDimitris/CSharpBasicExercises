/*
 * Write a C# program to check if an array contains an odd number.
 * 
 * Test Data:
 * Original array: [2, 4, 7, 8, 6]
 * 
 * Check if an array contains an odd number? True
 */

namespace CheckOddNumberInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 7, 8, 6 };
            Console.WriteLine(OddInArray(array));
        }

        public static bool OddInArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1) return true;
            }
            return false;
        }
    }
}
