/*
 * Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".
 * Test Data:
 * Enter your age - 25
 * Expected Output:
 * You look older than 25
 */

namespace PrintAgeMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Please insert your age (int).");
                bool input = int.TryParse(Console.ReadLine(), out int age);

                if (input)
                {
                    Console.WriteLine("Your age is {0}.", Math.Abs(age));
                    break;
                } else
                {
                    Console.WriteLine("Invalid number.");
                }
            }
        }
    }
}
