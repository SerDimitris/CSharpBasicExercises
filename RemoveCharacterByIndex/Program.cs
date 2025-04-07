/*
 * Write a C# program that removes a specified character
 * from a non-empty string using the index of a character.
 * Test Data:
 * w3resource
 * Sample Output:
 * wresource
 * w3resourc
 * 3resource
 */

namespace RemoveCharacterByIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a string.");
            string input = Console.ReadLine();

            while (true && (input != null))
            {
                Console.WriteLine("Please insert an index you want to remove.");
                bool inputIndex = int.TryParse(Console.ReadLine(), out int index);

                if (inputIndex)
                {
                    Console.WriteLine("The string without the character is {0}.", input.Remove(index, 1));
                    break;
                } else Console.WriteLine("Invalid indexer.");
            }
        }
    }
}
