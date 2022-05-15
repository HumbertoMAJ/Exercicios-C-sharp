using System;

namespace exercicio_1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = Int32.Parse(Console.ReadLine());
            int anos = 0;
            int mes = 0;
            int dia = 0;

            anos = idade / 365;
            idade= idade % 365;
            mes = idade / 30;
            dia = idade % 30;
           

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(mes + " mes(es)");
            Console.WriteLine(dia + " dia(s)");
        }
    }
}
