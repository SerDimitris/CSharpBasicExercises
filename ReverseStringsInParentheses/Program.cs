/*
 * Write a C# program to reverse the strings contained in each
 * pair of matching parentheses in a given string. It should
 * also remove the parentheses from the given string.
 */

namespace ReverseStringsInParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseRemoveParentheses("This (si (doog)) example"));
        }

        public static string ReverseRemoveParentheses(string str)
        {
            int lid = str.LastIndexOf('(');

            if (lid == -1) return str;

            int rid = str.IndexOf(")", lid);

            string reversedSubstring = new string(str.Substring(lid + 1, rid - lid -1).Reverse().ToArray());

            return ReverseRemoveParentheses
                (
                str.Substring(0, lid) + reversedSubstring + str.Substring(rid + 1)
                );
        }
    }
}
