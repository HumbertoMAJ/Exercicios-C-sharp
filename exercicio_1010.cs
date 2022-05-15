using System;
using System.Globalization;

namespace exercicio_1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p1 = Console.ReadLine();
            string p2 = Console.ReadLine();

            string[] valor1 = p1.Split(' ');
            int codigoP1 = Int32.Parse(valor1[0]);
            int numeroP1 = Int32.Parse(valor1[1]);
            double valorP1 = double.Parse(valor1[2],CultureInfo.InvariantCulture);

            string[] valor2 = p2.Split(' ');
            int codigoP2 = Int32.Parse(valor2[0]);
            int numeroP2 = Int32.Parse(valor2[1]);
            double valorP2 = double.Parse(valor2[2], CultureInfo.InvariantCulture);

            double valorTotal = (numeroP1 * valorP1) + (numeroP2 * valorP2);
            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
