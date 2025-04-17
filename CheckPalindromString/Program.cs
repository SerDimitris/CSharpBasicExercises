/*
 * Write a C# program to check if a given string is a palindrome or not.
 * 
 * Sample Example:
 * For 'aaa' the output should be true
 * For 'abcd' the output should be false
 */

namespace CheckPalindromString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindromeString("aaa"));
            Console.WriteLine(IsPalindromeString("abcd"));
        }

        public static bool IsPalindromeString(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] != s[j]) return false;
            }
            return true;
        }
    }
}
