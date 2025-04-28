/*
 * Write a C# Sharp program to count positive and
 * negative numbers in a given array of integers.
 * 
 * Sample Output:
 * 
 * Original Array elements: 10 -11 12 -13 14 -18 19 -20
 * Number of positive numbers: 4
 * Number of negative numbers: 4
 * 
 * Original Array elements: -4 -3 -2 0 3 5 6 2 6
 * Number of positive numbers: 5
 * Number of negative numbers: 3
 * 
 * Original Array elements:
 * Number of positive numbers: 0
 * Number of negative numbers: 0
 */

namespace CountPositivesAndNegativesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 10, -11, 12, -13, 14, -18, 19, -20 };
            int[] array2 = { -4, -3, -2, 0, 3, 5, 6, 2, 6 };
            int[] array3 = { };

            Console.WriteLine(CountOfPosAndNegs(array1));
            Console.WriteLine(CountOfPosAndNegs(array2));
            Console.WriteLine(CountOfPosAndNegs(array3));
        }

        public static string CountOfPosAndNegs(int[] array)
        {
            int countPos = 0;
            int countNegs = 0;

            foreach (int i in array)
            {
                if (i > 0) countPos++;
                else if (i < 0) countNegs++;
            }

            return ($"Number of positive numbers: {countPos}\nNumber of negative numbers: {countNegs}\n");
        }
    }
}
