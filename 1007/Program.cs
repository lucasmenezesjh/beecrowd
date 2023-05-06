using System;
using System.Globalization;

namespace Beecrowd
{
    public class program
    {

        public static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int D = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int DIFERENCA= (A * B - C * D);

            Console.WriteLine($"DIFERENCA = {DIFERENCA}");
            Console.Read();

        }
    }
}
