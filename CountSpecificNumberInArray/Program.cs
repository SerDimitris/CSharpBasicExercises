/*
 * Write a C# program to count a specified number in a given array of integers.
 * 
 * Test Data:
 * Input an integer: 5
 * 
 * Sample Output
 * Number of 5 present in the said array: 2
 */


namespace CountSpecificNumberInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 5, 3, 2, 6, 5, 7, 9, 5, 4, 2, 1, 8 };

            while (true)
            {
                Console.WriteLine("Please insert int to find in array.");
                bool input = int.TryParse(Console.ReadLine(), out int i);

                if (input)
                {
                    var count = ints.Count(n => n == i);
                    Console.WriteLine("The number {0} was found {1} {2} in the array.", i, count,
                        (count > 1 ? "times" : "time"));
                    break;
                } else Console.WriteLine("Invalid input.");
            }
        }
    }
}
