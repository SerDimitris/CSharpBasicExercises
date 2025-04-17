/*
 * Write a C# program that accepts a list of integers and
 * checks how many integers are needed to complete the range.
 * 
 * Sample Example [1, 3, 4, 7, 9], between 1-9 -> 2, 5, 6, 8
 * are not present in the list.
 * 
 * So output will be 4.
 */

namespace CompleteMissingNumbersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckMissingNumbers(new int[] { 4, 2, 5, 1}));
        }

        public static int CheckMissingNumbers(int[] array)
        {
            int count = 0;
            int minValue = array.Min();
            int maxValue = array.Max();

            for (int i = minValue + 1; i <= maxValue - 1; i++)
            {
               if (!array.Contains(i)) count++;
            }
            return count;
        }
    }
}
