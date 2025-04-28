/*
 * Write a C# Sharp program to convert an integer
 * to a string and a string to an integer.
 */

namespace IntegerStringAndViceVersa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberString = "20";
            int number = 25;

            int convertedString = Convert.ToInt32(numberString);
            string convertedInteger = Convert.ToString(number);

            Console.WriteLine("The string to int: {0} and type: {1}", convertedString, convertedString.GetType());
            Console.WriteLine("The number to string: {0} and type: {1}", convertedInteger, Convert.ToString(number).GetType());
        }
    }
}