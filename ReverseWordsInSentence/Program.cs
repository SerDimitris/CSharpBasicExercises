/* 
 * Write a C# program to reverse the words of a sentence.
 * Sample Output:
 * Original String: Display the pattern like pyramid using the alphabet.
 * Reverse String: alphabet. the using pyramid like pattern the Display
 */

namespace ReverseWordsInSentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert a string.");
                string? inputString = Console.ReadLine();
                string? reversedInput = "";
                List<string> wordList = new List<string>();

                if (inputString?.Length > 1)
                {
                    string[] words = inputString.Split(new[] {' '}, StringSplitOptions.None);

                    for (int i = words.Length - 1; i >= 0; i--)
                    {
                        reversedInput += words[i] + " ";
                    }
                    wordList.Add(reversedInput);
                    
                    foreach (string word in wordList) Console.WriteLine(word);
                    break;
                }
            }
        }
    }
}
