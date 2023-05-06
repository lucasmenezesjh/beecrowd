using System;
using System.Globalization;

namespace Beecrowd
{
    public class program
    {

        public static void Main(string[] args)
        {
            int NUMERO = int.Parse(Console.ReadLine());
            int HORAS = int.Parse(Console.ReadLine());
            double SALARIO = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double SALARY = HORAS * SALARIO;

            Console.WriteLine($"NUMBER = {NUMERO}");
            Console.WriteLine($"SALARY = U$ {SALARY.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.Read();

        }
    }
}
