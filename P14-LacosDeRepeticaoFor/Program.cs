using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_LacosDeRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 14 Exercício");

            for (int multiplicador = 1; multiplicador <= 20; multiplicador++)
            {
                for (int contador = 0; contador <= 20; contador++)

                    //Tabuada do 1 ao 20
                    //Descrição detalhada
                    //Console imprime na primeira linha 1 * 0 = 0
                {
                    Console.Write(multiplicador + " * " + contador + " = " + multiplicador * contador);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
