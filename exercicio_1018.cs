using System;
using System.Globalization;

namespace exercicio_1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("pt-BR");


            int valor = Int32.Parse(Console.ReadLine(), culture);
            Console.WriteLine(valor);

            int[] numeros = new int[] { 100, 50, 20, 10, 5, 2, 1 };

            for (int i = 0; i < numeros.Length; i++)
            {
                int qtdNotas = valor / numeros[i];
                Console.WriteLine(qtdNotas + " nota(s) de R$ " + numeros[i].ToString("F2", culture));
                valor = valor % numeros[i];
            }


        }
    }
}
