/*
 * Write a C# Sharp program to remove all non-letter characters from a given string.
 * 
 * Orginal string: Py@th12on
 * Remove all characters from the said string which are non-letters: Python
 * 
 * Orginal string: Python 3.0
 * Remove all characters from the said string which are non-letters: Python
 * 
 * Orginal string: 2^sdfds*^*^jlljdslfnoswje34u230sdfds984
 * Remove all characters from the said string which are non-letters: sdfdsjlljdslfnoswjeusdfds
 */

using System.Text.RegularExpressions;

namespace RemoveNonLetterCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exampleOne = "Py@th12on";
            string exampleTwo = "Python 3.0";
            string exampleThree = "2^sdfds*^*^jlljdslfnoswje34u230sdfds984";

            Console.WriteLine("{0} :: {1}", exampleOne, RemoveNonLettersCharacters(exampleOne));
            Console.WriteLine($"{exampleTwo} :: {RemoveNonLettersCharacters(exampleTwo)}");
            Console.WriteLine(exampleThree + " :: " + RemoveNonLettersCharacters(exampleThree));
        }

        public static string RemoveNonLettersCharacters(string input)
        {
            return Regex.Replace(input, @"[^a-zA-Z]", "");
        }
    }
}
