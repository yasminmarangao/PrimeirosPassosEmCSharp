using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 18 - Fatorial.");

            int fatorial = 1;

            for (int n = 1; n < 10; n++)
            {
                fatorial *= n;
                Console.WriteLine($"O fatorial de {n} é = {fatorial}: ");
            }


            Console.ReadLine();
        }
    }
}
