using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_PA_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorR, cotacao, resultado;

            Console.Write("Digite um valor em reais: ");
            valorR = double.Parse(Console.ReadLine());

            cotacao = 5.25;

            resultado = valorR / cotacao;

            Console.Write(valorR + " reais convertido para dólares valerá: " + Math.Round(resultado,2));

            Console.ReadKey();
        }
    }
}
