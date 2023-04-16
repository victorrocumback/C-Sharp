using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_PA_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;

            Console.Write("Digite um número: ");
            number = double.Parse(Console.ReadLine());

            number = Convert.ToDouble(Math.Pow(number, 2));

            Console.Write("O número digitado elevado ao quadrado é: " + number);

            Console.ReadKey();
        }
    }
}
