using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 16 - Tabuada.");

            for (int linha  = 1; linha <= 10; linha++)
            {
                for (int coluna = 0; coluna <= 10; coluna++)
                {
                    Console.WriteLine($"{linha} x {coluna} = {linha*coluna}");
                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
