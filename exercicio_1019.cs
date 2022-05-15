using System;
using System.Globalization;

namespace exercicio_1019
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int seg = Int32.Parse(Console.ReadLine());

            int minutos = 0;
            int horas = 0;

            horas = seg / 3600; 
            seg = seg % 3600; 
            minutos = seg / 60;
            seg = seg % 60;


            Console.WriteLine(horas + ":" + minutos + ":" + seg);



        }
    }
}
