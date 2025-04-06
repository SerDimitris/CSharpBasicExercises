/*
 * Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y)*z and x*y + y*z.
 * Test Data:
 * Enter first number - 5
 * Enter second number - 6
 * Enter third number - 7
 * 
 * Expected Output:
 * Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
 */

namespace SpecifiedFormulWithThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert three numbers (int).");
                bool inputOne = int.TryParse(Console.ReadLine(), out int numb1);
                bool inputTwo = int.TryParse(Console.ReadLine(),out int numb2);
                bool inputThree = int.TryParse(Console.ReadLine(), out int numb3);

                if (inputOne && inputTwo && inputThree)
                {
                    Console.WriteLine("Result of specified numbers {0}, {1} and {2} is: {3} and {4}", numb1, numb2, numb3, ((numb1 + numb2) * numb3),
                        ((numb1 * numb2) + (numb2 * numb3)));
                    break;
                } else
                {
                    Console.WriteLine("Invalid numbers.");
                }
            }
        }
    }
}
