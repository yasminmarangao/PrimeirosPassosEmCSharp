using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            char primeiraLetra = 'a';
            Console.WriteLine($"A primeira letra do seu nome é: {primeiraLetra}");
            Console.ReadLine();

            // fazendo um casting = que é converter o numero para caractere 
            // esse 65 é o código de uma letra. Dá para ver outros codigos na tabela ASCII TABLE
            primeiraLetra = (char) 65; 
            Console.WriteLine($"A primeira letra do seu nome é: {primeiraLetra}");
            Console.ReadLine();

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine($"A primeira letra do seu nome é: {primeiraLetra}");
            Console.ReadLine();

            string titulo = "Alura cursos de tecnologia " + 2020;
            string cursosProgramacao = @" - .NET
 - Java
 - Javascript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();


            string saudacao = "Olá, meu nome é ";
            string nome = "Rômulo ";
            string continuacao = "e minha idade é ";
            int idade = 100;
            Console.WriteLine(saudacao + nome + continuacao + idade);
            Console.ReadLine();
        }
    }
}
