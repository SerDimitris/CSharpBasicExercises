/*
 * Write a C# program to check if a given string contains the 'w' character between 1 and 3 times.
 * 
 * Test Data:
 * Input a string (contains at least one 'w' char) : w3resource
 * Test the string contains 'w' character between 1 and 3 times:
 * 
 * Sample Output: True
 */

namespace CheckWAppearsOnetoThreeTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert string.");
                string? input = Console.ReadLine();

                if (input?.Length > 0)
                {
                    var count = input.Count(s => s == 'w');
                    Console.WriteLine("Test the string contians 'w' character between 1 and 3 times: {0}", (count >= 1 && count <= 3));
                    break;
                } else Console.WriteLine("Invalid input.");
            }
        }
    }
}
