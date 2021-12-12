using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 7 Condicionais");

            int idadeJoao = 19;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João é maior de 18 anos, o acesso ao Evento é PERMITIDO!.");
            }

            else
            {

                Console.WriteLine("João é menor de 18 anos, o acesso ao Evento é NEGADO!");

            }
            //O if (SE) é um operador de condição, o else (caso não/contrário) é um operador de condição contrária/oposta ao declado no if.

            Console.ReadLine();
        }
    }
}
