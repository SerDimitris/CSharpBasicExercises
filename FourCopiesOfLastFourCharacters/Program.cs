/*
 * Write a C# program to create a string of four copies,
 * taking the last four characters from a given string.
 * If the given string is less than 4, return the original one.
 * 
 * Sample Output:
 * Input a string : The quick brown fox jumps over the lazy dog.
 * dog.dog.dog.dog.
 */

using System.Collections;
using System.Collections.Concurrent;

namespace FourCopiesOfLastFourCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = null;

            while (true)
            {
                Console.WriteLine("Please insert string.");
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    {
                        strings = input.Split(' ');
                        break;

                    }
                } else Console.WriteLine("Invalid input.");
            }
            string lastString = strings[strings.Length - 1];

            if (lastString.Length < 4)
            {
                Console.WriteLine("The last string is: " + lastString);
            }
            else
            {
                string lastFour = lastString.Substring(lastString.Length - 4);
                Console.WriteLine("Result: " + string.Concat(Enumerable.Repeat(lastFour, 4)));
            }
        }
    }
}
