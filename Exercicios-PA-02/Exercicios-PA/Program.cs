using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_PA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Digite úm número: ");
            number = int.Parse(Console.ReadLine());

            number = number * 2;
            Console.WriteLine("O dobro do valor digitado é: ");
            Console.WriteLine(number);

            Console.ReadKey();
        }
    }
}
