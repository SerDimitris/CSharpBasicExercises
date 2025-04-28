/*
 * Write a C# Sharp program to get the index number of
 * all lower case letters in a given string.
 * 
 * Sample Output:
 * Orginal string: Python
 * Indices of all lower case letters of the said string:
 * 1 2 3 4 5
 * 
 * Orginal string: JavaScript
 * Indices of all lower case letters of the said string:
 * 1 2 3 5 6 7 8 9
 */

using System.Text.RegularExpressions;

namespace IndicesOfLowercaseLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string example = "PythOOon";

            foreach (int i in LowercasesPosition(example)) Console.Write($"{i} ");
        }

        public static int[] LowercasesPosition(string s)
        {
            return s.Select((x, i) => i)
                .Where(i => char.IsLower(s[i]))
                .ToArray();
        }
    }
}