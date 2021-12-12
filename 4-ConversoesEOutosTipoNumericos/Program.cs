using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTipoNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 4");

            Double salario1 = 1200.50;

            int SalarioEmInteiro = (int)salario1;

            Console.WriteLine(SalarioEmInteiro);

            //Long é utilizado no lugar do Int para armazenar números muito grandes por ser uma variável de 64 bits
            //Para números muito pequenos, podemos usar  Short para até 5 digitos ou 16 bits

            long idade = 13000000000;

            Console.WriteLine("A idade do universo é de aproximadamente " + idade + " de anos.");

            float pontoFlutuante = 3.14f;

            double salario = 1270.50;
            int valor = (int)salario;
            Console.WriteLine(valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;

            Console.WriteLine(total);

            Console.ReadLine(); 
        }
    }
}
