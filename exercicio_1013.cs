using System;

namespace exercicio_1013
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');

            int a = int.Parse(valores[0]);        
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);

            int maior = (a + b + Math.Abs(a-b)) / 2;

            if(maior > c)
            {
                Console.WriteLine(maior + " eh o maior");
            }
            else
            {
                Console.WriteLine(c + " eh o maior");
            }

            
        }
    }
}
