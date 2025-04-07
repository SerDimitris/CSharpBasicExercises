/*
 * Write a C# program to check a pair of integers and
 * return true if one is negative and one is positive.
 * Sample Output:
 * Input first integer:
 * -5
 * Input second integer:
 * 25
 * Check if one is negative and one is positive:
 * True
 */

namespace CheckPositiveAndNegativePair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert two integers.");
                
                if ((int.TryParse(Console.ReadLine(), out int numb1)) && int.TryParse(Console.ReadLine(), out int numb2))
                {
                    if ((numb1 > 0) && (numb2 < 0) || (numb1 < 0) && (numb2 >0))
                    {
                        Console.WriteLine(true);
                        break;
                    } else
                    {
                        Console.WriteLine(false);
                        break;
                    }
                } else Console.WriteLine("Invalid input.");
            }
        }
    }
}
