/*
 * Write a C# Sharp program to swap two numbers.
 * Test Data:
 * Input the First Number : 5
 * Input the Second Number : 6
 * Expected Output:
 * After Swapping :
 * First Number : 6
 * Second Number : 5
 */

namespace SwapTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers (int).");

            if (!int.TryParse(Console.ReadLine(), out var num1)) Console.WriteLine("First number is invalid.");
            if (!int.TryParse(Console.ReadLine(), out var num2)) Console.WriteLine("Second number is invalid.");

            SwapNumbers(num1, num2);
        }

        public static void SwapNumbers(int num1, int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After Swapping: {num1}, {num2}");
        }
    }
}
