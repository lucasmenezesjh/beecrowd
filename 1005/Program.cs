using System;
using System.Globalization;

namespace Beecrowd
{
    public class program
    {

        public static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine($"MEDIA = {media.ToString("F5",CultureInfo.InvariantCulture)}");
            Console.Read();

        }
    }
}
