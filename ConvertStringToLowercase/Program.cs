/* 
 * Write a C# program to convert a given string into lowercase.
 */

namespace ConvertStringToLowercase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert a string.");
                string input = Console.ReadLine();

                if (input?.Length >= 1)
                {
                    string updatedInput = input.ToLower();
                    Console.WriteLine(updatedInput);
                    break;
                } else Console.WriteLine("Invalid input.");
            }
        }
    }
}
