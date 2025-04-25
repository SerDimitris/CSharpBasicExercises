/*
 * Write a C# Sharp program to get the file name
 * (including extension) from a given path.
 */

namespace GetFileNameFromPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tempStr;

            tempStr = "c:/csharp/ex/test.cpp";
            Console.WriteLine(test(tempStr));
        }

        public static string test(string file_path)
        {
            return file_path.Split('/').Last();
        }
    }
}
