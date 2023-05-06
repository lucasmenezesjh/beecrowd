using System;

namespace Beecrowd
{
    public class program
    {

        public static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int PROD = A * B;

            Console.WriteLine($"PROD = {PROD}");
            Console.Read();

        }
    }
}
