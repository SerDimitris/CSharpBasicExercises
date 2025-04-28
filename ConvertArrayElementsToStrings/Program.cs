/*
 * Write a C# Sharp program to convert all the values
 * of a given array of mixed values to string values.
 * 
 * Sample Output:
 * 
 * Printing original array elements and their types:
 * Value-> 25 :: Type-> System.Int32
 * Value-> Anna :: Type-> System.String
 * Value-> False :: Type-> System.Boolean
 * Value-> 4/15/2021 10:37:47 AM :: Type-> System.DateTime
 * Value-> 112.22 :: Type-> System.Double
 * 
 * Printing array elements and their types:
 * Value-> 25 :: Type-> System.String
 * Value-> Anna :: Type-> System.String
 * Value-> False :: Type-> System.String
 * Value-> 4/15/2021 10:37:47 AM :: Type-> System.String
 * Value-> 112.22 :: Type-> System.String
 */

namespace ConvertArrayElementsToStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] mixed = { 25, "Anna", false, new DateTime(2021, 4, 15), 112.22 };
            
            foreach(string s in MixedToString(mixed)) Console.WriteLine("Value {0} and tpye {1}.", s, s.GetType());
        }

        public static string[] MixedToString(object[] mixed)
        {
            return mixed.Select(x => x.ToString()!).ToArray();
        }
    }
}
