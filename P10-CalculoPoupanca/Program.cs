using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculoPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 10 Cálculo de Poupança");

            Double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                //o 0.0036 declarado é referente à conversão de 0,36%/100 do rendimento da poupança para a operação.

                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes +  " meses você terá R$ " + valorInvestido);

                // O operador ++ adicona mais 1 à operação, neste caso adicionará mais 1 mês até 12.
                contadorMes++;

            }


            Console.ReadLine();
        }
    }
}
