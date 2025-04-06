/* Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
 * Test Data:
 * Input the first number: 25
 * Input the second number: 4
 * Expected Output:
 * 25 + 4 = 29
 * 25 - 4 = 21
 * 25 x 4 = 100
 * 25 / 4 = 6
 * 25 mod 4 = 1
 */

namespace ArithmeticOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter the first number (int).");
                bool validNumb1 = int.TryParse(Console.ReadLine(), out int numb1);

                Console.WriteLine("Please enter the second number (int).");
                bool validNumb2 = int.TryParse(Console.ReadLine(), out int numb2);

                if (validNumb1 && validNumb2)
                {
                    Console.WriteLine("Add: " + (numb1 + numb2));
                    Console.WriteLine("Subtrack: " + (numb1 - numb2));
                    Console.WriteLine("Multipy: " + (numb1 * numb2));
                    Console.WriteLine("Divid: " + (numb1 / numb2));
                    break;
                } else
                {
                    Console.WriteLine("Invalid numbers.");
                }
            }
        }
    }
}
