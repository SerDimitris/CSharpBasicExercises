/*
 * Write a C# program to rotate an array (length 3) of integers in the left direction.
 * 
 * Test Data: Array1: [1, 2, 8]
 * After rotating array becomes: [2, 8, 1]
 */

namespace RotateArrayLeft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 8 };

            int temp = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = temp;

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
