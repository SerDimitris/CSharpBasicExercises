/*
 * Write a C# Sharp program to print Hello and your name in a separate line.
 */

namespace PrintHelloName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert your name.");
            string? inputName = Console.ReadLine();
            
            Console.Write($"Hello {inputName}!");
        }
    }
}
