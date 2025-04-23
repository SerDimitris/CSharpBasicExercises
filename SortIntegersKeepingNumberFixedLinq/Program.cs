/*
 * Write a C# program to sort the integers in
 * ascending order without moving the number -5.
 * 
 * >>>Linq version<<<
 * 
 */
namespace SortIntegersKeepingNumberFixedLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = SortNumbers(new int[] { -5, 236, 1, 2, -5, -5, 321, 3455 });

            foreach (int i in ints) Console.WriteLine(i.ToString());
        }

        public static int[] SortNumbers(int[] numbers)
        {
            int[] num = numbers.Where(x => x != -5).OrderBy(x => x).ToArray();

            int ctr = 0;

            return numbers.Select(x => x != -5 ? num[ctr++] : -5).ToArray();
        }
    }
}
