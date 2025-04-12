
/*
 * Write a C# program to get a string of two characters from a given string.
 * The first and second characters of the given string must be "P" and "H", so PHP will be "PH".
 * 
 * Test Data: PHP
 * Sample Output: PH
 */

namespace ExtractPHFromString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "PHP";
            string updatedInput = "";

            if (input.Length >= 2 && (input[0]) == 'P')
            {
                updatedInput += input[0];
                if (input[1] == 'H') updatedInput += input[1];
                Console.WriteLine(updatedInput);
            } else Console.WriteLine("Invalid input.");
        }
    }
}
