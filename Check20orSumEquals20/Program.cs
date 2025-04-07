/* Write a C# program to check the sum of the two given integers.
 * Return true if one of the integers is 20 or if their sum is 20.
 */

namespace Check20orSumEquals20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert two integers.");

                if ((int.TryParse(Console.ReadLine(), out int numb1)) && (int.TryParse(Console.ReadLine(), out int numb2)))
                {
                    if ((numb1 == 20) || (numb2 == 20) || ((numb1 + numb2 == 20)))
                    {
                        Console.WriteLine(true);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(false);
                        break;
                    }
                } else Console.WriteLine("Invalid input.");
            }
        }
    }
}
