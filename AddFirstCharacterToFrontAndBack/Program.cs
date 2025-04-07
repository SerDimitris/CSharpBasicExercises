/*
 * Write a C# program to create a string from a given string (length 1 or more)
 * with the first character added at the front and back.
 * Sample Output:
 * Input a string : The quick brown fox jumps over the lazy dog.
 * TThe quick brown fox jumps over the lazy dog.T
 */

namespace AddFirstCharacterToFrontAndBack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please give a string.");
                string input = Console.ReadLine();

                if (input?.Length > 1)
                {
                    char firstChar = input[0];

                    Console.WriteLine(firstChar + input + firstChar);
                    break;
                } else Console.WriteLine("Invalid input.");
            }
        }
    }
}
