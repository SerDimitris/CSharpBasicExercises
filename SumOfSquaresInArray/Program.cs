/*
 * Write a C# Sharp program to find the sum of squares
 * of elements in a given array of integers.
 * 
 * Sample Output:
 * Sum of squares of elements of the said array: 14
 * Sum of squares of elements of the said array: 29
 */

namespace SumOfSquaresInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(SumOfSquares(ints));
        }

        public static int SumOfSquares(int[] nums)
        {
            return nums.Sum(x => x * x);
        }
    }
}
