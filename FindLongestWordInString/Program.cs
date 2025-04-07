namespace FindLongestWordInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert a string.");
                string? input = Console.ReadLine();

                if (input?.Length > 1)
                {
                    string[] words = input!.Split(" ");

                    string longestWord = "";
                    int maxLength = 0;

                    foreach( string word in words)
                    {
                        if (word.Length > maxLength)
                        {
                            maxLength = word.Length;
                            longestWord = word;
                        }
                    }
                    Console.WriteLine("The longest word in the string is: {0}", longestWord);
                    break;
                } else Console.WriteLine("Invalid input.");
            }
        }
    }
}
