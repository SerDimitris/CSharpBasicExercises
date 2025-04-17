/*
 * Write a C# program to find the pair of adjacent
 * elements that has the largest product of the given array.

 */


namespace MaxProductofAdjacentElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckMaxProductInArray(new int[] {2, 3, 4, 5, 6, 6, 4, 3, 2, 1}));
        }

        public static int CheckMaxProductInArray(int[] array)
        {
            int max = int.MinValue;

            for (int i = 0; i <= array.Length - 2; i++) max = (array[i] * array[i + 1]) > max ? (array[i] * array[i + 1]) : max;

            return max;
        }
    }
}
