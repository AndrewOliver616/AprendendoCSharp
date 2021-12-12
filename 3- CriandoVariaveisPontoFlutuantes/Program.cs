using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__CriandoVariaveisPontoFlutuantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Variáveis Ponto Flutuantes");

            double Salario = 1200.70;

           //Para números decimais usa-se o Double na variável, lembrar que para o número
           // saia com as casas decimais, deve-se utilizar a virgula, no C# usa-se ponto  no lugar da virgula.

            double divisao = 5.0 / 2;
            Console.WriteLine(divisao);

            double peso = 4.0;
            int quantidade = 10;
            Console.WriteLine(peso * quantidade);

            Console.WriteLine("Olá, seu salário terá um aumento de " + Salario + " Reais a partir de 1 de Janeiro");
            Console.WriteLine("A execução foi finalizada, Aperte ENTER para sair . . .");
            Console.ReadLine();
        }
    }
}
