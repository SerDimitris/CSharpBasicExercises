/*
 * Write a C# program to create a new string from a given string
 * where the first and last characters change their positions.
 * Test Data:
 * w3resource
 * Python
 * Sample Output:
 * e3resourcw
 * nythoP
 */

namespace SwapFirstAndLastCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert string.");
                string? inputString = Console.ReadLine();

                if (inputString?.Length > 1)
                {
                    char firstChar = inputString[0];
                    char lastChar = inputString[^1];

                    string middle = inputString.Substring(1, inputString.Length - 2);
                    string swappedString = lastChar + middle + firstChar;

                    Console.WriteLine(swappedString);
                    break;
                } else Console.WriteLine("Invalid input.");
            }
        }
    }
}
