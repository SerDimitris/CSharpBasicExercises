/*
 * Write a C# Sharp program to swap a two-digit number and
 * check whether the given number is greater than its swap value.
 * 
 * Sample Output:
 * Input an integer value:
 * Check whether the said value is greater than its swap value: True
 */

namespace CheckSwappedTwoDigitNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert a two-digit integer");

                if (int.TryParse(Console.ReadLine(), out int result) && (result >= 10 && result < 100))
                {
                    Console.WriteLine("The swapped value is{0} greater than the original value.",
                    (IsSwappedGreaterThanOriginal(result) ? "" : " not"));
                    break;
                } else Console.WriteLine("Invalid input.");
            }
        }

        public static bool IsSwappedGreaterThanOriginal(int x)
        {
            int a = x / 10;
            int b = x % 10;

            return (b > a);
        }
    }
}
