/*
 * Write a C# program to check if a string starts with a specified word.
 * Note: Suppose the sentence starts with "Hello"
 * 
 * Sample Data: string1 = "Hello how are you?"
 * Result: Hello.
 * Sample Output:
 * Input a string : Hello how are you?
 * True
 */

namespace CheckStringsStartsWithWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = null;
            const string FIRSTWORD = "Hello";

            while (true)
            {
                Console.WriteLine("Please insert string.");
                string? input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    strings = input.Split(' ');
                    Console.WriteLine(FIRSTWORD.Equals(strings[0]));
                    break;
                } else Console.WriteLine("Invalid input.");
            }
        }
    }
}
