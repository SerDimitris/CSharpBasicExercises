/*
 * Write a C# program to convert
 * a hexadecimal number to a decimal number.
 * Sample Output:
 * Hexadecimal number: 4B0
 * Convert to-
 * Decimal number: 1200
 */

namespace HexToDec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a hex string.");
            string hex = Console.ReadLine();

            int dec = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine(dec);
        }
    }
}
