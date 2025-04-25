/*
 * Write a C# Sharp program to check the length of a given string is odd or even.
 * Return 'Odd length' if the string length is odd otherwise 'Even length'.
 * 
 * Sample Output:
 * Original string: PHP
 * Convert the letters of the said string into alphabetical order: Odd length
 * 
 * Original string: javascript
 * Convert the letters of the said string into alphabetical order: Even length
 * 
 * Original string: python
 * Convert the letters of the said string into alphabetical order: Even length
 */

namespace OddEvenLengthString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsStringLengthEven("php"));
        }

        public static string IsStringLengthEven(string str)
        {
            return new string(str.Length % 2 == 0 ? "Even length" : "Odd length");
        }
    }
}
