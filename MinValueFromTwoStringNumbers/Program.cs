/*
 * Write a C# Sharp program to find the minimum value
 * from two numbers given to you, represented as a string.
 */

namespace MinValueFromTwoStringNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = { "12,3", "2", "3,33", "0,1111" };
            Console.WriteLine(input(numbers));
        }

        public static double input(string[] numbers)
        {
            return numbers.Select(x => Convert.ToDouble(x)).Min();
        }
    }
}
