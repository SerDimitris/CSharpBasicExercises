/*
 * Write a C# program to compute the sum of all the elements of a list of integers.
 * 
 * Test Data:
 * List: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
 * 
 * Sample Output
 * Sum: 69
 */

namespace SumOfArrayElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The sum is: {SumOfList(FillList())}");
        }

        public static List<int> FillList()
        {
            var numbers = new List<int>();

            Console.WriteLine("Insert an int to fill array. Type 'done' to finish.");

            while (true)
            {
                Console.Write(">> ");
                string input = Console.ReadLine();

                if (input.ToLower() == "done") break;

                if (!int.TryParse(input, out int value)) Console.WriteLine("Invalid input. Try again.");
                else numbers.Add(value);
            }

            return numbers;
        }

        public static int SumOfList(List<int> list)
        {
            int sum = list.Sum();
            return sum;
        }
    }
}
