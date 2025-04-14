/*
 * Write a C# program to check if a number appears as the first or last
 * element of an array of integers. The array length is 1 or more.
 * 
 * Test Data:
 * Input an integer: 25
 * 
 * Sample Output: False
 */


namespace CheckNumberFirstorLastInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = FillArray();
            Console.WriteLine(IsIntFirstOrLast(numbers, CheckInput()));

        }

        public static int[] FillArray()
        {
            var numbers = new List<int>();
            Console.WriteLine("Please insert integer. Type 'done' if you finish.");

            while (true)
            {
                Console.Write(">> ");
                string input = Console.ReadLine();

                if (input.ToLower() == "done") break;

                if (int.TryParse(input, out int number)) numbers.Add(number);
                else Console.WriteLine("Invalid input. Try again.");
            }
            numbers.ForEach(Console.WriteLine);

            return numbers.ToArray();
        }

        public static int CheckInput()
        {
            while (true)
            {
                Console.WriteLine("Please enter the integer to find in array if its first or last.");
                if (!int.TryParse(Console.ReadLine(), out int number)) Console.WriteLine("Invalid input. Try again.");
                else return number;        
            }
        }

        public static bool IsIntFirstOrLast(int[] numbers, int n)
        {
            return (numbers.First() == n) || (numbers.Last() == n);
        }
    }
}
