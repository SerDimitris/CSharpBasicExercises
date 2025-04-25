/*
 * Write a C# Sharp program to convert the letters of a given string
 * (same case-upper/lower) into alphabetical order.
 * 
 * Sample Output:
 * Original string: PHP
 * Convert the letters of the said string into alphabetical order: HPP
 * 
 * Original string: javascript
 * Convert the letters of the said string into alphabetical order: aacijprstv
 * 
 * Original string: python
 * Convert the letters of the said string into alphabetical order: hnopty
 */

using System.Runtime.InteropServices;

namespace AlphabeticalOrderStringLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test1 = "python";
            Console.WriteLine(AlphabeticalOrderString(test1));
        }

        public static string AlphabeticalOrderString(string s)
        {
            return new string(s.OrderBy(x => x).ToArray());
        }
    }
}
