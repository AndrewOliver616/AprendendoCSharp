using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 8 Condicionais2");

            int idadeJoao = 16;
            int acompanhados = 2;

            //No C# para utilizar a condicionais OU utiliza-se o ||
            if (idadeJoao >= 18 || acompanhados >= 2)
            {
                Console.WriteLine("O acesso ao Evento é PERMITIDO!.");
            }

            else
            {

                Console.WriteLine("O acesso ao Evento é NEGADO!");
            }

            //O if (SE) é um operador de condição, o else (caso não/contrário) é um operador de condição contrária/oposta ao declado no if.



            int idadeJose = 19;
            bool acompanhado = true;
            string mensagemAdicional;


            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado";
            }

            else

            {
                mensagemAdicional = "João não está acompanhado";
            }
                
            

            //0 && representa a conectivo logico E
            if (idadeJose >= 18 || acompanhado == true)
            {
                Console.WriteLine(" Bem-vindo! Pode entrar na festa");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar na festa desacompanhado!");
            }

            //Exercício
            double salario = 2599.0;

            if (salario < 2600.0)
            {
                Console.WriteLine("A sua aliquota é de 15%");
                Console.WriteLine("Você pode deduzir até R$ 350");
            }

            if (salario < 3750.0)
            {
                Console.WriteLine("A sua aliquota é de 22,5%");
                Console.WriteLine("Você pode deduzir até R$ 636");
            }

           
            Console.ReadLine();
        }
    }
}
