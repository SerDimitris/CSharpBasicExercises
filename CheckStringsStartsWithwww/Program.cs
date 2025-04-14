/*
 * Write a C# program to check if a given string starts
 * with "w" and is immediately followed by two "ww".
 * 
 * Test Data:
 * Input a string: www
 * Sample Output: False
 */


namespace CheckStringsStartsWithwww
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert string.");
                string input = Console.ReadLine();

                if (input.Length > 0)
                {
                    Console.WriteLine(CountW(input));
                    break;
                }
                else Console.WriteLine("Invalid input.");
            }
        }

        public static bool CountW(string s)
        {
            int count = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == 'w') count++;

                if (s.Substring(i, 2).Equals("ww") && count >= 2 ) return true;
            }
            return false;
        }
    }
}
