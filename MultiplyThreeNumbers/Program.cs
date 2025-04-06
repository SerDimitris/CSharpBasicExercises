/*
 * Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
 * Test Data:
 * Input the first number to multiply: 2
 * Input the second number to multiply: 3
 * Input the third number to multiply: 6
 * Expected Output:
 * 2 x 3 x 6 = 36
 */

namespace MultiplyThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Please enter the first number (int).");
                if (!int.TryParse(Console.ReadLine(), out int numb1))
                {
                    Console.WriteLine("Invalid first number.");
                    continue;
                }

                Console.WriteLine("Please enter the second number (int).");
                if (!int.TryParse(Console.ReadLine(), out int numb2))
                {
                    Console.WriteLine("Invalid second number.");
                    continue;
                }

                Console.WriteLine("Please enter the third number (int).");
                if (!int.TryParse(Console.ReadLine(), out int numb3))
                {
                    Console.WriteLine("Invalid third number.");
                    continue;
                }

                int result = numb1 * numb2 * numb3;

                Console.WriteLine($"The result is: {result}");
                break;
            }

        }
    }
}
