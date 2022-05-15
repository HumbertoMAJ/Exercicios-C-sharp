using System;
using System.Globalization;

namespace exercicio_1021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-US");


            decimal valor = decimal.Parse(Console.ReadLine(), culture);
            Console.WriteLine("NOTAS:");

            decimal[] numeros = new decimal[] { 100, 50, 20, 10, 5, 2};

            for (int i = 0; i < numeros.Length; i++)
            {
               
                decimal qtdNotas = valor / numeros[i];
                Console.WriteLine((int)qtdNotas + " nota(s) de R$ " + numeros[i].ToString("F2", culture));
                valor = valor % numeros[i];
            }


    
            Console.WriteLine("MOEDAS:");
            decimal[] numeros02 = new decimal[] {1.00M, 0.50M, 0.25M, 0.10M, 0.05M, 0.01M };
            

            for (int i = 0; i < numeros02.Length; i++)
            {
               decimal qtdNotas = valor / numeros02[i];
               Console.WriteLine((int)qtdNotas + " moeda(s) de R$ " + numeros02[i].ToString("F2", culture));
                valor = valor % numeros02[i];
            }


        }
    }
}

