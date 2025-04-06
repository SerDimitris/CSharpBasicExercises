/* Write a C# Sharp program that prints the multiplication table of a number as input.
 * Test Data:
 * Enter the number: 5
 * Expected Output:
 * 5 * 0 = 0
 * 5 * 1 = 5
 * 5 * 2 = 10
 * 5 * 3 = 15
 * ....
 * 5 * 10 = 50
 */

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert a number (int) to print its multiplication table.");
                bool validInput = int.TryParse(Console.ReadLine(), out int number);

                if (validInput)
                {
                    Console.WriteLine("The multiplication table of " + number + " is:");
                    for (int i = 0; i <= 10; i++) Console.WriteLine(number + " * " + i + " = " + (number * i));
                    break;
                } else
                {
                    Console.WriteLine("Invalid number.");
                }
            }
        }
    }
}
