/*
 * Write a C# program to check two given numbers where
 * one is less than 100 and the other is greater than 200.
 * 
 * Sample Output:
 * Input a first number(<100): 75
 * Input a second number(>100): 250
 * True
 */

namespace CheckNumbersLessThan100AndGreaterThan200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert two integers.");
                bool inputOne = int.TryParse(Console.ReadLine(), out int numb1);
                bool inputTwo = int.TryParse(Console.ReadLine(), out int numb2);

                if (inputOne && inputTwo)
                {
                    Console.WriteLine(IsLessOrGreater(numb1) && IsLessOrGreater(numb2));
                    break;
                } else Console.WriteLine("Invalid inputs.");
            }
        }

        public static bool IsLessOrGreater(int n)
        {
            return (n < 100) || (n > 200);
        }
    }
}
