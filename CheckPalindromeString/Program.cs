/*
 * Write a C# program to check if a given int is a palindrome or not.
 * 
 * Sample Example:
 * For '12321' the output should be true
 * For '1234' the output should be false
 */

namespace CheckPalindromeInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsArrayPalindrom(new int[] { 1, 2, 3, 2, 1}));
            Console.WriteLine(IsArrayPalindrom(new int[] { 1, 2, 3, 4 }));
        }

        public static bool IsArrayPalindrom(int[] array)
        {
            for (int i = 0, j = array.Length - 1; i < j; i++, j--)
            {
                if (array[i] != array[j]) return false;
            }
            return true;
        }
    }
}
