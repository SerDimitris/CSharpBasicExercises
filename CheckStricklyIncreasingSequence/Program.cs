/*
 * Write a C# program to check whether it is possible to
 * create a strictly increasing sequence from a given
 * sequence of integers as an array.
 */

namespace CheckStricklyIncreasingSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckSequence(new int[] {2, 3, 1, 4}));
        }

        public static bool CheckSequence(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    count++;
                    if (count > 1) return false;
                }
                if (i > 0 && array[i - 1] >= array[i + 1])
                {
                    if (i + 2 < array.Length && array[i] >= array[i + 2])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
