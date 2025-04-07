/*
 * Write a C# program to print odd numbers from 1 to 99. Prints one number per line.
 * Sample Output:
 * Odd numbers from 1 to 99. Prints one number per line.
 */

namespace PrintOddNumbersOneToNinetyNine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i += 2) Console.WriteLine(i);
        }
    }
}
