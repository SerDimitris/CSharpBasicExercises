/*
 * Write a C# Sharp program to multiply all elements
 * of a given array of numbers by array length.
 */

namespace MultiplyArrayElementsByLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6 };
            Array.ForEach(MultiplyElements(testArray), Console.WriteLine);
        }

        public static int[] MultiplyElements(int[] array)
        {
            int len = array.Length;

            return array.Select(x => x * len).ToArray();
        }
    }
}
