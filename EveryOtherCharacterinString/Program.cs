/*
 * Write a C# program to create a string of every other character
 * (odd position) from the first position of a given string.
 * 
 * Test Data:
 * Input a string: w3resource
 * Sample Output: wrsuc
 */

namespace EveryOtherCharacterinString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert string.");
                string? input = Console.ReadLine();

                if (input.Length > 0)
                { 
                    Console.WriteLine(EveryOddPosition(input));
                    break;
                } else Console.WriteLine("Invalid input.");
            }
        }

        public static string EveryOddPosition(string s)
        {
            string updatedS = string.Empty;

            for (int i = 0; i <= s.Length; i += 2)
            {
                updatedS += s[i];
            }
            return updatedS;
        }
    }
}
