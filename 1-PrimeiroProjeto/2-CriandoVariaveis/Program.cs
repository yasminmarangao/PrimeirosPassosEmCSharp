using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade = 32;
            Console.WriteLine($"A idade da Sarah é: {idade} ");

            idade = 10;
            Console.WriteLine($"A idade de Joao é: {idade}");

            idade = idade + 23;
            Console.WriteLine($"A idade de Yasmin é: {idade} ");

            Console.WriteLine("Execução Finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
