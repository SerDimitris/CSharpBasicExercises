/*
 * Write a C# program to check if a given positive
 * number is a multiple of 3 or 7.
 * 
 * Sample Output:
 * Input first integer:
 * 15
 * True
 */

using System.Net.Http.Headers;

namespace CheckMultipleOf3Or7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert an integer.");
                int.TryParse(Console.ReadLine(), out int number);

                if (number > 0)
                {
                    Console.WriteLine(IsMultiple(number));
                    break;
                } else Console.WriteLine("Invalid input.");
            }
        }

        public static bool IsMultiple(int n)
        {
            return (n % 3 == 0) || (n % 7 == 0);
        }
    }
}
