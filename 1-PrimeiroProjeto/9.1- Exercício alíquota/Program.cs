using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1__Exercício_alíquota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando verificação de alíquota mediante valor de salário.");

            double salario = 3752.0;

            if (salario < 1900.0)
            {
                Console.WriteLine("Você não tem valor de desconto de Imposto de renda no salário.");
            }
            if ((salario >= 1900.0) & (salario <= 2800.0))
            {
                Console.WriteLine("O valor da alíquota do seu imposto de renda é de 7.5% e pode deduzir na declaração o valor de R$142 reais.");
            }
            if ((salario >= 2800.01) & (salario <= 3751.01))
            {
                Console.WriteLine("O valor da alíquota do seu imposto de renda é de 15% e pode deduzir na declaração o valor de R$350 reais.");
            }
            if ((salario >= 3751.01) & (salario <= 4664.0))
            {
                Console.WriteLine("O valor da sua alíquota é de 22,5% e pode deduzir na declaração o valor de R$636 reais.");
            }
            if (salario > 4664.0)
            {
                Console.WriteLine("Você não tem valor de desconto de Imposto de Renda no salário.");
            }                    
            
            Console.ReadLine();
        }
    }
}
