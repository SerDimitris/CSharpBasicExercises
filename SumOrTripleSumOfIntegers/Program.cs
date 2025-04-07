/* Write a C# program to compute the sum of two given integers.
 * If two values are the same, return the triple of their sum.
 */

namespace SumOrTripleSumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert two integers.");

                if ((int.TryParse(Console.ReadLine(), out int numb1)) && (int.TryParse(Console.ReadLine(), out int numb2))) {
                    if (numb1 == numb2)
                    {
                        Console.WriteLine("The triple sum of {0} and {1} is: {2}", numb1, numb2, ((numb1 + numb2) * 3));
                        break;
                    } else
                    {
                        Console.WriteLine("The sum of {0} and {1} is: {2}", numb1, numb2, (numb1 + numb2));
                        break;
                    }
                } else Console.WriteLine("Invalid input.");
            }
        }
    }
}
