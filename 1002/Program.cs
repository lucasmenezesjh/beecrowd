using System;
using System.Globalization;

namespace Beecrowd
{
    public class program
    {

        public static void Main(string[] args)
        {
            double n = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = n * (raio * raio);
            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.Read();

        }
    }
}
