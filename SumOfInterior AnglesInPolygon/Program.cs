/*
 * Write a C# Sharp program to find the sum of the
 * interior angles (in degrees) of a given polygon.
 * Input the number of straight lines.
 */

namespace SumOfInterior_AnglesInPolygon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int test1 = 3;
            int test2 = 6;

            Console.WriteLine(SumOfAngles(test1));
            Console.WriteLine(SumOfAngles(test2));
        }

        public static int SumOfAngles(int lines)
        {
            return (lines - 2) * 180;
        }
    }
}