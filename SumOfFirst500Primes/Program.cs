/*
 * Write a C# program to compute the sum of the first 500 prime numbers.
 * Sample Output:
 * Sum of the first 500 prime numbers:
 * 824693
 */

namespace SumOfFirst500Primes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            int number = 2;

            while (count < 500)
            {
                if (IsPrime(number))
                {
                    sum += number;
                    count++;
                }
                number++;
            }
            Console.WriteLine(sum);
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
