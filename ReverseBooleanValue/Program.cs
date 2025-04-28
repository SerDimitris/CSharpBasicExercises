/*
 * Write a C# Sharp program to reverse a Boolean value.
 * 
 * Sample Output:
 * 
 * Original value: False
 * Reverse value: True
 * 
 * Original value: True
 * Reverse value: False
 */

namespace ReverseBooleanValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseBool(true));
            Console.WriteLine(ReverseBool(false));
        }

        public static bool ReverseBool(bool value)
        {
            return !value;
        }
    }
}
