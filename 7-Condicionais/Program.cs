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

            int idadeJoao = 16;
            int acompanhado = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João é maior de 18 anos, o acesso ao Evento é PERMITIDO!.");
            }

            else
            {
                if (acompanhado >= 2)
                {
                    Console.WriteLine("João é menor de 18 anos, mas está acompanhado, o acesso é PERMITIDO!");
                }
                else
                {
                    Console.WriteLine("João é menor de 18 anos, o acesso ao Evento é NEGADO!");
                }

            }
            //O if (SE) é um operador de condição, o else (caso não/contrário) é um operador de condição contrária/oposta ao declado no if.

            int idadeJose = 15;
            int acompanhado2 = 2;

            if(idadeJose >= 18)
            {
                Console.WriteLine("José tem 18 anos ou mais, Bem-vindo! Pode entrar na festa");
            }
            else
            {
               if(acompanhado2 >= 2)
                {
                    Console.WriteLine("José menor de 18 anos, mas está acompanhado, pode entrar na fest, Diverta-Se!");
                }
               else
                {
                    Console.WriteLine("José ainda não possui 18 anos ou mais, não pode entrar na festa desacompanhado!");
                }
                
            }
            Console.ReadLine();
        }
    }
}
