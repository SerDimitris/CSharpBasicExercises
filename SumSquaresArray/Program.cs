/*
 * Write a C# Sharp program to find the sum of squares of
 * elements in a given array of integers.
 */

namespace SumSquaresArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, 5, 6 };

            Console.WriteLine(SumSquaresArray(array));
        }

        public static int SumSquaresArray(int[] array)
        {
            return (int)array.Sum(x => Math.Pow(x, 2));
        }
    }
}
