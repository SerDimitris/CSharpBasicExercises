namespace FindCenturyOfYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert year.");
            if (int.TryParse(Console.ReadLine(), out int year) && year > 0)
            {
                int century = (year + 99) / 100;
                Console.WriteLine(century);
            } else Console.WriteLine("Please add a positive year.");
        }
    }
}
