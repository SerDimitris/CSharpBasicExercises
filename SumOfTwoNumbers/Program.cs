/*
 * Write a C# Sharp program to print the sum of two numbers.
 */

namespace SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb1 = 0;
            int numb2 = 0;
            int result;

            Console.WriteLine("Please insert two numbers (int).");
            
            if (!int.TryParse(Console.ReadLine(), out numb1)) Console.WriteLine("First number invalid.");
            if (!int.TryParse(Console.ReadLine(), out numb2)) Console.WriteLine("Second number invalid");

            result = numb1 + numb2;

            Console.WriteLine($"The result is: {result}");

        }
    }
}
