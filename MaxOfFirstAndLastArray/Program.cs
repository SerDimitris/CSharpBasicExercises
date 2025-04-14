/*
 * Write a C# program to get the largest value between the
 * first and last element of an array (length 3) of integers.
 * 
 * Test Data:
 * Array1: [1, 2, 5, 7, 8]
 * Highest value between first and last values of the said array: 8
 */

namespace MaxOfFirstAndLastArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 5, 7, 8 };
            int max = int.MinValue;

            foreach (int i in array)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine("Highest value between first and last values of the said array is: {0}.", max);
        }
    }
}
