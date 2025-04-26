/*
 * Write a C# Sharp program to count a specified character (both cases) in a given string.
 */

namespace CountSpecificCharInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a word.");
            string input = Console.ReadLine();

            Console.WriteLine("Insert char to look for.");
            char charInput = char.Parse(Console.ReadLine());
            char upInput = char.ToUpper(charInput);
            char lowInput = char.ToLower(charInput);

            int sum = 0;

            foreach (char c in input)
            {
                if (c == lowInput || c == upInput) sum++;
            }

            Console.WriteLine(sum);
        }
    }
}
