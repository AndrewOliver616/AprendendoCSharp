using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 5 - Caracteres e Textos");

            //No Char (Character) pode incluir um caracter, que pode ser hexadecimal(números que expressam outros caracteres)
            char letra = 'a';
            Console.WriteLine(letra);

            char valor = (char)65;
            Console.WriteLine(valor);

            valor = (char)(valor + 1);
            Console.WriteLine(valor);

            //Nas Strings podemos incluir textos compostos.
            string palavra = "Alura Cursos de Tecnologia " + 2021;
            Console.WriteLine(palavra);

            string cursos = @"- .NET
- JAVA
- JavaScript";
            Console.WriteLine(cursos);

            //Podemos usar a marcação sobre marcação para adcionar mais informações, exemplo abaixo:

            palavra = palavra + "Cursos Atualizados sempre";
            Console.WriteLine(palavra);

            //A saída será: Alura Cursos de Tecnologia 2021 Cursos Atualizados sempre.


            //exercício;

            string saudacao = "Olá, meu nome é ";
            string nome = "Rômulo ";
            string continuacao = "e minha idade é ";
            int idade = 100;
            Console.WriteLine(saudacao + nome + continuacao + idade);

            Console.ReadLine();
        }
    }
}
