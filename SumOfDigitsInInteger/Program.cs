/*
 * Write a C# program and compute the sum of an integer's digits.
 * Sample Output:
 * Input a number(integer): 12
 * Sum of the digits of the said integer: 3
 */

namespace SumOfDigitsInInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int mod = 0;
            int temp;
            while (true)
            {
                Console.WriteLine("Please insert integer.");
                bool input = int.TryParse(Console.ReadLine(), out int number);
                temp = number;

                if (input)
                {
                    do
                    {
                        mod = temp % 10;
                        sum = sum + mod;
                        temp = temp / 10;
                    } while (temp > 0);
                    Console.WriteLine("Sum of the {0}'s digits is: {1}", number, sum);
                    break;
                } else Console.WriteLine("Invalid input.");
            }
        }
    }
}
