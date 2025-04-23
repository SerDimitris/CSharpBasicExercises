
/*
 * Write a C# program to calculate the sum of all integers in a rectangular matrix.
 * However, exclude those integers located below an integer of value 0.
 * 
 * Sample matrix Example:
 * [0, 2, 3, 2],
 * [0, 6, 0, 1],
 * [4, 0, 3, 0]
 * 
 * Eligible integers which will be participated to calculate the sum -
 * matrix = [X, 2, 3, 2],
 *          [X, 6, X, 1],
 *          [X, X, X, X]
 *          
 * Therefore sum will be: 2 + 3 + 2 + 6 + 1 = 14
 */

using System.ComponentModel.Design;

namespace SumOfMatrixWithZeroCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MatrixTotal(new int[,]
            {
                { 0, 2, 3, 2 },
                { 0, 6, 0, 1 },
                { 4, 0, 3, 0 }
            }));
        }

        public static int MatrixTotal(int[,] array)
        {
            int sum = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i,j] == 0)
                    {
                        break;
                    }
                    
                    sum += array[i, j];
                } 
            }
            return sum;
        }
    }
}
