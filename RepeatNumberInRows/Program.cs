/*
 * Write a C# program that takes a number as input and
 * displays it four times in a row (separated by blank spaces),
 * and then four times in the next row, with no separation.
 * You should do it twice: Use the console. Write and use {0}.
 * Test Data:
 * Enter a digit: 25
 * Expected Output:
 * 25 25 25 25
 * 25252525
 * 25 25 25 25
 * 25252525
*/
namespace RepeatNumberInRows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert number");
                bool input = double.TryParse(Console.ReadLine(), out double number);

                if (input)
                {
                    Console.WriteLine("{0} {0} {0} {0}\n{0}{0}{0}{0}\n{0} {0} {0} {0}\n{0}{0}{0}{0}", number);
                    break;
                } else Console.WriteLine("Invalid number.");
            }
        }
    }
}
