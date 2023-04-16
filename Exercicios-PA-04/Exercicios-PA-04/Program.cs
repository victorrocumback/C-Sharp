using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_PA_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, resultado;

            Console.Write("Digite o valor de A: ");
            A = Double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            B = Double.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            C = Double.Parse(Console.ReadLine());

            resultado = Math.Pow(A, 2) * 5 - C / (B - A / 100 + 4);

            resultado = Math.Round(resultado, 3);

            Console.WriteLine("O Resultado da expressão é: " + resultado);

            Console.ReadKey();


        }
    }
}
