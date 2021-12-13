using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto P12 Cálculo de Investimento em Longo Prazo.");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            //Repetição de laços FOR encadeados
            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    //*= multiplica o valor antes da = pelo indice indicado em seguida.
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao termino do investimento você terá R$ " + valorInvestido + " de retorno");

            Console.ReadLine();
        }
    }
}
