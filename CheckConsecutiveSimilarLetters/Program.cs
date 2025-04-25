/*
 * Write a C# Sharp program to check if a given
 * string contains two similar consecutive letters.
 * 
 * Sample Output:
 * Original string: PHP
 * Test for consecutive similar letters! False
 * 
 * Original string: PHHP
 * Test for consecutive similar letters! True
 * 
 * Original string: PHPP
 * Test for consecutive similar letters! True
 * 
 * Original string: PPHP
 * Test for consecutive similar letters! True
 */

namespace CheckConsecutiveSimilarLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test1 = "PHP";
            string test2 = "PHHP";

            Console.WriteLine(IsConsecutive(test1));
            Console.WriteLine(IsConsecutive(test2));
        }

        public static bool IsConsecutive(string s)
        {
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1]) return true;
            }
            return false;
        }
    }
}
