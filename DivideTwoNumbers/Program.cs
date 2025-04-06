/*
 * Write a C# Sharp program to print the result of dividing two numbers.
 */

namespace DivideTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb1 = 0;
            int numb2 = 0;
            double result;

            Console.WriteLine("Please enter two numbers (int).");

            if (!int.TryParse(Console.ReadLine(), out numb1)) Console.WriteLine("First number is invalid.");
            if (!int.TryParse(Console.ReadLine(), out numb2)) Console.WriteLine("Second number is invalid");

            result = (double) numb1 / numb2;

            Console.WriteLine($"The result is: {result}");
        }
    }
}
