/*
 * Write a C# Sharp program that takes four numbers as input to calculate and print the average.
 * Test Data:
 * Enter the First number: 10
 * Enter the Second number: 15
 * Enter the third number: 20
 * Enter the four number: 30
 * 
 * Expected Output:
 * The average of 10 , 15 , 20 , 30 is: 18
 */

namespace AverageFourNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert four numbers (int).");
                bool inputOne = int.TryParse(Console.ReadLine(), out int numb1);
                bool inputTwo = int.TryParse(Console.ReadLine(), out int numb2);
                bool inputThree = int.TryParse(Console.ReadLine(), out int numb3);
                bool inputFour = int.TryParse(Console.ReadLine(), out int numb4);

                if (inputOne && inputTwo && inputThree && inputFour)
                {
                    Console.WriteLine($"The average of {numb1}, {numb2}, {numb3} and {numb4} is: "
                    + ((numb1 + numb2 + numb3 + numb4) / 4));
                    break;
                } else
                {
                    Console.WriteLine("Invalid numbers.");
                }
            }
        }
    }
}
