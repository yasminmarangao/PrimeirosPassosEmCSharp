using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___EncadeandoLaçosFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 13 - Encadeando Laços de Repetição For.");

            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }

                fatorRendimento += 0.0010;
            }

            Console.WriteLine($"Ao término do investimento você terá R${valorInvestido}.");
            Console.ReadLine();
        }

    }
}
