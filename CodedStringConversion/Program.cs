/*
 * Write a C# Sharp program to create a coded string
 * from a given string, using a specified formula.
 * 
 * Replace all 'P' with '9', 'T' with '0', 'S' with '1', 'H' with '6' and 'A' with '8'.
 * 
 * Sample Output:
 * 969
 * J8V81CRI90
 */

namespace CodedStringConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringConversion("pPtTaA"));
        }

        public static string StringConversion(string input)
        {
            Dictionary<char, char> diction = new Dictionary<char, char>() {
                { 'p', '9' },
                { 'P', '9'},
                { 't', '0'},
                { 'T', '0'},
                { 's', '1'},
                { 'S', '1'},
                { 'H', '6'},
                { 'h', '6'},
                { 'a', '8'},
                { 'A', '8'}
            };

            string result = string.Empty;

            foreach (char c in input)
            {
                if (diction.ContainsKey(c)) result += diction[c];
                else result += c;
            }
            return result;
        }
    }
}
