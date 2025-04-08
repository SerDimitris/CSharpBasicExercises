/*
 * Write a C# program to find the size of
 * a specified file in bytes.
 * Sample Output:
 * Size of a file: 31
 */

namespace FileSizeInBytes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\dsera\Documents\sample.txt";

            FileInfo fileInfo = new FileInfo(filepath);
            long fileSize = fileInfo.Length;

            Console.WriteLine("File's size is {0} bytes.", fileSize);
        }
    }
}
