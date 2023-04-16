using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_PA_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string MaiorIdade;

            Console.Write("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            MaiorIdade = idade >= 18 ? "Você é maior de idade" : "Você é menor de idade";
            Console.Write(MaiorIdade);

            Console.ReadKey();
        }
    }
}
