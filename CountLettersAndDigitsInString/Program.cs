/*
 * Write a C# Sharp program to get the number of
 * letters and digits in a given string.
 * 
 * Sample Output:
 * Original string:: Python 3.0
 * Number of letters: 6 Number of digits: 2
 * 
 * Original string:: dsfkaso230samdm2423sa
 * Number of letters: 14 Number of digits: 7
 */

using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace CountLettersAndDigitsInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountLetters("Python 3.0"));
            Console.WriteLine(CountNumbers("Python 3.0"));
        }

        public static int CountLetters(string s)
        {
            int c = Regex.Matches(s, @"[a-zA-Z]").Count;
            return c;
        }

        public static int CountNumbers(string s)
        {
            int c = Regex.Matches(s, @"\d+").Count;
            return c;
        }
    }
}
