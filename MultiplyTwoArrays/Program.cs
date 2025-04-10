/*
 * Write a C# program to multiply the corresponding
 * elements of two integer arrays.
 * 
 * Sample Output:
 * Array1: [1, 3, -5, 4]
 * Array2: [1, 4, -5, -2]
 * 
 * Multiply corresponding elements of two arrays:
 * 1 12 25 -8
 */

namespace MultiplyTwoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[4];
            int[] arr2 = new int[4];

            for (int i = 0; i < arr1.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine($"Array 1: Please insert #{i + 1} integer: ");
                    if (int.TryParse(Console.ReadLine(), out int numb))
                    {
                        arr1[i] = numb;
                        break;
                    } else Console.WriteLine("Invlaid input.");
                }
            }
            for (int i = 0; i< arr2.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine($"Array 2: Please insert #{i + 1} integer: ");
                    if (int.TryParse(Console.ReadLine(), out int numb))
                    {
                        arr2[i] = numb;
                        break;
                    } else Console.WriteLine("Invalid input.");
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine((arr1[i] * arr2[i]));
            }
        }
    }
}
