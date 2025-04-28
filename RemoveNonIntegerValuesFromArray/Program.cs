/*
 * Write a C# Sharp program to remove all values except
 * integer values from a given array of mixed values.
 * 
 * Sample Output:
 * 
 * Original array elements: 25 Anna False 4/24/2021 11:43:11 AM -112 -34.67
 * 
 * After removing all the values except integer values from the said array of mixed values: 25 -112
 */

using System.Security.Cryptography.X509Certificates;

namespace RemoveNonIntegerValuesFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] obj = { 25, "Anna", false, new DateOnly(), -112, -34.75 };
            int[] newArray = IntegerArrayOnly(obj);
            
            for (int i = 0; i < newArray.Length; i++) Console.Write(newArray[i] + " ");
        }

        public static int[] IntegerArrayOnly(object[] array)
        {
            return array.OfType<int>().ToArray();
        }
    }
}
