using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 6 - Atribuição de Variáveis");

            int idade = 26;
            int idadeAndre = idade; //NOTA: Quando se atribui um valor a uma variável indicando outra variáve,
            //esse valor não acompanha as alterações da primeira, se eu mudar a idade para valor 30, a IdadeAndre permanaecerá 26. O valor é guardado.

            
            Console.WriteLine(idadeAndre);
            Console.WriteLine(idade);

            idade = 28; // note que mesmo após essa alteração na variade, IdadeAndre permanecerá 26
            Console.WriteLine(idade);

            Console.ReadLine();
        }
    }
}
