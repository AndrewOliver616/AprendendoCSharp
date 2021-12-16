using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escrevendo Asteriscos com o BREAK
            Console.WriteLine("Executando Projeto 13 - FOR Encadeado");

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;

                }

                Console.WriteLine();
            }

            //Uma forma diferente de fazer o desenho de asteriscos sem usar o BREAK

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)

                    Console.Write("*");


                Console.WriteLine();
            }

            //Exercício Repetição

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)

                {
                    Console.Write("a");
                }

                Console.WriteLine();
            }



            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            //exercio 2

            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if (coluna > linha)
                    {
                        break;
                    }
                    Console.Write(coluna + 1);
                }

                Console.WriteLine();
            }



                Console.ReadLine();
            
        }

    }
}
