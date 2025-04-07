/*
 * Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
 * Test Data:
 * Enter the amount of celsius: 30
 * Expected Output:
 * Kelvin = 303
 * Fahrenheit = 86
 */

namespace CelsiusToKelvinAndFahrenheit 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double KELVIN = 273.15d;
            while (true)
            {
                Console.WriteLine("Please insert Celsius degrees.");
                bool input = double.TryParse(Console.ReadLine(), out double temperature);

                if (input)
                {
                    Console.WriteLine("The {0} Celsius to Kelvin is: {1}", temperature, (temperature + KELVIN));
                    Console.WriteLine("The {0} Celsius to Fahrenheit is: {1}", temperature, ((temperature * 9 / 5) + 32));
                    break;
                } else Console.WriteLine("Invalid temperature.");
            }
        }
    }
}
