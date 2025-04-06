/*
 * Write a C# Sharp program to print the results of the specified operations.
 * Test data:
 * -1 + 4 * 6
 * (35+5) % 7
 * 14 + -4 * 6 / 11
 * 2 + 15 / 6 * 1 - 7 % 2
 */

namespace SpecifiedOperationsResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OperationFour(2, 15, 6, 1, 7, 2));
        }

        public static int OperationOne(int numb1, int numb2, int numb3)
        {
            return numb1 + numb2 * numb3;
        }

        public static int OperationTwo(int numb1, int numb2, int numb3)
        {
            return (numb1 + numb2) % numb3;
        }

        public static int OperationThree(int numb1, int numb2, int numb3, int numb4)
        {
            return numb1 + (numb2 * numb3) / numb4;
        }

        public static int OperationFour(int numb1, int numb2, int numb3, int numb4, int numb5, int numb6)
        {
            return numb1 + numb2 / numb3 * numb4 - numb5 % numb6;
        }
    }
}
