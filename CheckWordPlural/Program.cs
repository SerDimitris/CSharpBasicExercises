/*
 * Write a C# Sharp program to check whether a word is plural or not.
 * 
 * Sample Output:
 * Is 'Exercise' is plural? False
 * Is 'Exercises' is plural? True
 * Is 'Books' is plural? True
 * Is 'Book' is plural? False
 */

namespace CheckWordPlural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test1 = "Book";
            string test2 = "Books";

            Console.WriteLine(IsWordPural(test1));
            Console.WriteLine(IsWordPural(test2));
        }

        public static bool IsWordPural(string word)
        {
            return (word.Last() == 's');
        }
    }
}
