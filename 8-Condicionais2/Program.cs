using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 8 Condicionais2");

            int idadeJoao = 16;
            int acompanhado = 2;

            //No C# para utilizar a condicionais OU utiliza-se o ||
            if (idadeJoao >= 18 || acompanhado >= 2)
            {
                Console.WriteLine("O acesso ao Evento é PERMITIDO!.");
            }

            else
            {

                Console.WriteLine("O acesso ao Evento é NEGADO!");
            }

            //O if (SE) é um operador de condição, o else (caso não/contrário) é um operador de condição contrária/oposta ao declado no if.



            int idadeJose = 19;
            int acompanhado2 = 3;
            //bool acompanhados = acompanhado2;
            bool acompanhados = true;

            //0 && representa a conectivo logico E
            if (idadeJose >= 18 && acompanhados == true)
            {
                Console.WriteLine(" Bem-vindo! Pode entrar na festa");
            }
            else
            {
                Console.WriteLine("Não pode entrar na festa desacompanhado!");
            }
            Console.ReadLine();
        }
    }
}
