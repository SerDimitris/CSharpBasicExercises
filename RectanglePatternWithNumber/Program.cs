/*
 * Write a C# program that takes a number as input and displays
 * a rectangle of 3 columns wide and 5 rows tall using that digit.
 * Test Data:
 * Enter a number: 5
 * Expected Output:
 * 555
 * 5 5
 * 5 5
 * 5 5
 * 555
 */

namespace RectanglePatternWithNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert a number.");
                bool input = double.TryParse(Console.ReadLine(), out double number);

                if (input)
                {
                    Console.WriteLine("{0}{0}{0}\n{0} {0}\n{0} {0}\n{0} {0}\n{0}{0}{0}", number);
                    break;
                }
                else Console.WriteLine("Invalid number.");
            }
        }
    }
}
