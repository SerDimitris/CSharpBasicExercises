namespace CheckWithin20of100or200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please insert an integer.");

                if(int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine(result(number));
                    break;
                } else Console.WriteLine("Invalid input.");
            }
        }

        public static bool result(int x)
        {
            if (Math.Abs(x - 100) <= 20)return true;            
            else if (Math.Abs(x - 200) <= 20) return true;
            return false;
        }
    }
}
