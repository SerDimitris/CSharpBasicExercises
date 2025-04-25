/*
 * Write a C# Sharp program to remove the first and last elements from a given string.
 * 
 * Sample Output:
 * Original string: PHP
 * After removing first and last elements: H
 * 
 * Original string: Python
 * After removing first and last elements: ytho
 * 
 * Original string: JavaScript
 * After removing first and last elements: avaScrip
 */
namespace RemoveFirstAndLastCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveFirstLastElements("Dimitris"));
        }

        public static string RemoveFirstLastElements(string input)
        {
            return (input.Length > 2) ? input.Substring(1, input.Length - 2) : input;
        }
    }
}
