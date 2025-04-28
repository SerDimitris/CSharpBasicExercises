/*
 * Write a C# Sharp program to find the cumulative sum of an array of numbers.
 * 
 * Sample Output:
 * 
 * Orginal Array elements: 1 3 4 5 6 7
 * Cumulative sum of the said array elements: 1 4 8 13 19 26
 * 
 * Orginal Array elements: 1.2 -3 4.1 6 -5.47
 * Cumulative sum of the said array elements: 1.2 -1.8 2.3 8.3 2.83
 */

namespace CumulativeSumΟfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1, 3, 4, 5, 6, 7 };
            double[] arraySecond = { 1.2, - 3, 4.1, 6, - 5.47 };

            foreach (double d in CumulativeSum(array)) Console.Write(d + " ");
            Console.WriteLine();
            foreach (double d in CumulativeSum(arraySecond)) Console.Write("{0:F2} ", d);
        }

        public static double[] CumulativeSum(double[] numbers)
        {
            return numbers.Select((x, i) => numbers.Take(i + 1).Sum()).ToArray();
        }
    }
}
