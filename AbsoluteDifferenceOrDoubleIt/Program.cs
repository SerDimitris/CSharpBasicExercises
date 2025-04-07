/* Write a C# program to get the absolute value of the difference
 * between two given numbers. Return double the absolute value of
 * the difference if the first number is greater than the second number.
 */

namespace AbsoluteDifferenceOrDoubleIt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert two integes.");

                if ((int.TryParse(Console.ReadLine(), out int numb1)) && (int.TryParse(Console.ReadLine(), out int numb2)))
                {
                    if (numb1 > numb2)
                    {
                        Console.WriteLine(Math.Abs(2 * (numb1 - numb2)));
                        break;
                    } else
                    {
                        Console.WriteLine(Math.Abs(numb1 - numb2));
                        break;
                    }
                } else Console.WriteLine("Invalid input.");
            }
        }
    }
}
