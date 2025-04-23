/*
 * Write a C# program to sort the integers in
 * ascending order without moving the number -5.
 */

namespace SortIntegersKeepingNumberFixed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = SortArray(new int[] { 4, 3, 2, -5, 1, 7 });

            foreach (int i in result) Console.WriteLine(i + " ");
        }

        static int[] SortArray(int[] array)
        {
            const int STEADY = -5;
            int pos = -1;
            List<int> list = new List<int>();
            List<int> movable = new List<int>();

            foreach (int i in array)
            {
                if (i != STEADY) movable.Add(i);
            }

            movable.Sort();

            int movableIndex = 0;
            foreach (int i in array)
            {
                if (i == STEADY) list.Add(STEADY);
                else
                {
                    list.Add(movable[movableIndex]);
                    movableIndex++;
                }
            }
            
            return list.ToArray();
        }
    }
}
