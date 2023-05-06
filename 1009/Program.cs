using System;
using System.Globalization;

namespace Beecrowd
{
    public class program
    {

        public static void Main(string[] args)
        {
            string VENDEDOR = Console.ReadLine();
            double SALARIO = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double VENDAS = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double TOTAL = SALARIO + (VENDAS * 0.15);


            Console.WriteLine($"TOTAL = R$ {TOTAL.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadLine();
        }
    }
}
