using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___LaçoDeRepetiçãoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12 - Laço de repetição FOR");
            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine($"Após {contadorMes} meses, você terá: {valorInvestido} reais.");
            }

            Console.ReadLine();
        }
    }
}
