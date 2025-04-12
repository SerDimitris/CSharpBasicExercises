/*
 * Write a C# program to check if "HP" appears at the second
 * position in a string and return the string without "HP".
 * 
 * Test Data: PHP Tutorial
 * 
 * Sample Output:
 * P Tutorial
 */

namespace RemoveHPFromString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "PHP Tutorial";

            Console.WriteLine((data.Substring(1, 2).Equals("HP") ? data.Remove(1, 2) : data));
           
        }
    }
}
