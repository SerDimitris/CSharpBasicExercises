/*
 * Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
 * 
 * Sample Output:
 * Input a first number: -5
 * Input a second number: 8
 * True
 */


namespace CheckIntegerInRangeMinus10to10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert two integers.");
                bool input1 = int.TryParse(Console.ReadLine(), out int numb1);
                bool input2 = int.TryParse(Console.ReadLine(), out int numb2);

                if (input1 && input2)
                {
                    Console.WriteLine(CheckIntegersRange(numb1, numb2));
                    break;
                } else Console.WriteLine("Invalid inputs.");
            }
        }

        public static bool CheckIntegersRange(int numb1, int numb2)
        {
            return (numb1 >= -10 && numb1 <= 10) || (numb2 >= -10 && numb2 <= 10);
        }
    }
}
