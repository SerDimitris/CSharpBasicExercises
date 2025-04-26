/*
 * Write a C# Sharp program to get the ASCII value of a given character.
 * 
 * Sample Output:
 * Ascii value of 1 is: 49
 * Ascii value of A is: 65
 * Ascii value of a is: 97
 * Ascii value of # is: 35
 */

namespace GetASCIIValueOfCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char test1 = '1';
            char test2 = 'a';
            char test3 = 'A';
            char test4 = '#';

            Console.WriteLine(CharToASCII(test1));
            Console.WriteLine(CharToASCII(test2));
            Console.WriteLine(CharToASCII(test3));
            Console.WriteLine(CharToASCII(test4));
        }

        public static int CharToASCII(char c)
        {
            return (int)c;
        }

    }
}
