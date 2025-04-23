/*
 * Write a C# program to check if a given number is present in an array of numbers.
 */

namespace CheckNumberInArrayLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            int n = 20;

            Console.WriteLine(CheckNumberInArray(array, n));
        }

        static public bool CheckNumberInArray(int[] array, int n)
        {
            return array.Contains(n);
        }
    }
}