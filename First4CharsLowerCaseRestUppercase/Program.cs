/*
 * Write a C# program to create a string where the first 4 characters
 * are in lower case. If the string is less than 4 letters, make the whole string in upper case.
 * 
 * Test Data:
 * Input a string: w3r
 * Sample Output: W3R
 */

namespace First4CharsLowerCaseRestUppercase
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
                    string upper = (input.Length > 4) ? ((input.Substring(0, 4).ToUpper() + input.Substring(4))) : input.ToUpper();
                    Console.WriteLine(upper);
                    break;
                } else Console.WriteLine("Invalid input.");
            }
        }
    }
}
