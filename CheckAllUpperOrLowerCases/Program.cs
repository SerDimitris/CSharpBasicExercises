/*
 * Write a C# Sharp program to check if a given string
 * contains only lowercase or uppercase characters.
 */

namespace CheckAllUpperOrLowerCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "dimi";

            Console.WriteLine("The input {0} has {1} cases.", input, (CheckCasesLower(input) ? "lower" : (CheckCasesUpper(input) ? "upper" : "random")));
        }

        public static bool CheckCasesUpper(string input)
        {
            return input == input.ToUpper();
        }

        public static bool CheckCasesLower(string input)
        {
            return input == input.ToLower();
        }
    }
}
