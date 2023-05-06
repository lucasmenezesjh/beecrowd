using System;
using System.Globalization;

namespace Beecrowd
{
    public class program
    {

        public static void Main(string[] args)
        {
            string[] valor1 = Console.ReadLine().Split(' ');
            int cod = int.Parse(valor1[0]);
            int quant = int.Parse(valor1[1]);
            double valor = double.Parse(valor1[2], CultureInfo.InvariantCulture);

            string[] valor2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(valor2[0]);
            int quant2 = int.Parse(valor2[1]);
            double value = double.Parse(valor2[2], CultureInfo.InvariantCulture);

            double resultado = (quant * valor) + (quant2 * value);
            Console.WriteLine($"VALOR A PAGAR: R$ {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.Read();


        }
    }
}
