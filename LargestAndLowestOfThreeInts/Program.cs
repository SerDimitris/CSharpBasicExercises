/*
 * Write a C# program to find the largest and lowest values from three integer values.
 * 
 * Test Data:
 * Input first integer: 15
 * Input second integer: 25
 * Input third integer: 30
 * 
 * Sample Output
 * Largest of three: 30
 * Lowest of three: 15
 */

namespace LargestAndLowestOfThreeInts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            while (true)
            {
                Console.WriteLine("Please insert first int.");
                bool firstInput = int.TryParse(Console.ReadLine(), out int result);

                if (!firstInput) Console.WriteLine("Invalid input. Try again.");
                else
                {
                    num1 = result;
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Please insert second int.");
                bool secondInput = int.TryParse(Console.ReadLine(), out int result);

                if (!secondInput) Console.WriteLine("Invalid input. Try again.");
                else
                {
                    num2 = result;
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("Please insert third int.");
                bool thirdInput = int.TryParse(Console.ReadLine(), out int result);

                if (!thirdInput) Console.WriteLine("Invalid input. Try again.");
                else
                {
                    num3 = result;
                    break;
                }
            }
            Console.WriteLine("The largest is {0} and the lowest {1}.", Math.Max(num1, Math.Max(num2, num3)), Math.Min(num1, Math.Min(num2, num3)));
        }
    }
}
