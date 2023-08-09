using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Múltiplos_de_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 17 - Múltiplos de 3.");

            for (int num = 0; num <= 100; num++) 
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine($"Os múltiplos de 3 entre 0 e 100 são: {num}");
                   
                } 
            }

            Console.ReadLine();

            //Outra maneira de fazer o for e mostrar os múltiplos de 3.
            for (int i = 0; i < 100; i+=3)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
