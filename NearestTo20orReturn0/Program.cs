/*
 * Write a C# program that checks the nearest value of 20
 * of two given integers and return 0 if two numbers are same.
 * 
 * Test Data:
 * Input first integer: 15
 * Input second integer: 12
 * 
 * Sample Output: 15
 */

namespace NearestTo20orReturn0
{
    internal class Program
    {
        const int N = 20;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert two integers.");
                bool firstInput = int.TryParse(Console.ReadLine(), out int num1);
                bool secondInput = int.TryParse(Console.ReadLine(), out int num2);

                if (firstInput && secondInput)
                {
                    Console.WriteLine("{0}", Math.Abs(num1) == Math.Abs(num2) ? 0 : (Math.Abs(num1 - N) < Math.Abs(num2 - N) ? num1 : num2));
                    break;
                }
                else Console.WriteLine("Invalid input.");
            }
        }
    }
}
