/*
 * Write a C# Sharp program to remove all vowels from a given string.
 * 
 * Sample Output:
 * Orginal string: Python
 * After removing all the vowels from the said string: Pythn
 * 
 * Orginal string: C Sharp
 * After removing all the vowels from the said string: C Shrp
 * 
 * Orginal string: JavaScript
 * After removing all the vowels from the said string: JvScrpt
 */

using System.Text.RegularExpressions;

namespace RemoveVowelsFromString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exampleOne = "Python";
            string exampleTwo = "C Sharp";
            string exampleThree = "JavaScript";

            Console.Write($"{exampleOne} :: {RemoveVowels(exampleOne)}\n{exampleTwo} :: {RemoveVowels(exampleTwo)}\n" +
                $"{exampleThree} :: {RemoveVowels(exampleThree)}");
        }

        public static string RemoveVowels(string text)
        {
            return Regex.Replace(text, @"[aeiouyAEIOUY]", "");
        }
    }
}