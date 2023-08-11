using System;

namespace Algoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lista 01
            #region exer 01
            //Lendo um número em inteiro

            //Console.Write("Digite um número em inteiro: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"O número digitado em inteiro é: {num}");

            #endregion exer 01

            #region exer 02
            //Lendo um número em real.

            //Console.WriteLine($"Digite um numero em real: ");
            //double numero = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"O número digitado foi:{numero} ");

            #endregion exer 02

            #region exer 03
            //Imprimindo tres valores e mostrando a soma deles.

            //Console.Write("Digite o primeiro numero: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Digite o segundo numero: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Digite o terceiro numero: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"A soma entre {num1} + {num2} + {num3} é = {num1+num2+num3}");


            #endregion exer 03

            #region exer 04

            //Console.Write("Digite um número para que seja impresso o seu quadrado: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"O quadrado de {num} é: {(num*num)}");

            #endregion exer 04

            #region exer 05

            //Console.Write("Digite um número para que seja encontrada a quinta parte desse número: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"A quinta parte de {num} é: {(num/5)}");

            #endregion exer 05

            #region exer 06

            //Console.Write("Digite a temperatura em Celsius para convertê-la para Fahrenheit: ");
            //double temp = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"A temperatura {temp} graus de celsius para Fahrenheit é = {(temp*(9.0/5.0)+32.0)}");

            #endregion exer 06

            #region exer 07

            //Console.Write("Digite o primeiro numero: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Digite o segundo numero: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 > num2)
            //{
            //    Console.WriteLine($"{num1} é maior do que {num2}");
            //}
            //if (num1 == num2)
            //{
            //    Console.WriteLine("Os dois números digitados são iguais.");
            //}
            //if (num1 < num2)
            //{
            //    Console.WriteLine($"{num1} é menor que {num2}");
            //}

            #endregion exer 07

            #region exer 08

            //Console.Write("Digite um número: ");
            //double num = Convert.ToDouble(Console.ReadLine());

            //if (num >= 0)
            //{
            //    Console.WriteLine($"A raiz quadrada de {num} é: {Math.Sqrt(num)}");
            //}
            //if (num < 0)
            //{
            //    Console.WriteLine($"{num} ao quadrado é: {(num*num)}");
            //}

            #endregion exer 08

            #region exer 09

            //Console.Write("Digite um número: ");
            //long num = Convert.ToInt64(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("O numero digitado é par!");
            //}

            //else
            //{
            //    Console.WriteLine("O número digitado é impar!");

            #endregion exer 09

            #region exer 10

            //Console.Write("Digite o 1° numero: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Digite o 2° numero: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //if (num > num2)
            //{
            //    Console.WriteLine($"O numero {num} é maior que {num2}. A diferença entre eles é: {(num - num2)}");
            //}

            //if (num2 > num)
            //{
            //    Console.WriteLine($"O numero {num2} é maior que {num}. A diferença entre eles é: {(num2 - num)}");
            //}

            //if (num == num2)
            //{
            //    Console.WriteLine("Os dois numeros são iguais.");
            //}

            #endregion exer 10

            #region exer 11

            //Console.Write("Digite a 1a nota: ");
            //double nota1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Digite a 2a nota: ");
            //double nota2 = Convert.ToDouble(Console.ReadLine());

            //if (((nota1) >= 0 && (nota1 <= 10)) && ((nota2 >= 0) && (nota2 <= 10)))
            //{
            //    Console.WriteLine($"A media das notas é: {((nota1 + nota2) / 2)}");
            //}

            //else
            //{
            //    Console.WriteLine("Notas inválidas!");
            //}
            #endregion exer 11

            #region exer 12



            #endregion exer 12

            #region exer 13

            Console.Write("Digite o valor do seu salário em reais: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da prestação do empréstimo que você deseja solicitar: ");
            double emp = Convert.ToDouble(Console.ReadLine());

            if ((emp >= (salario * 0.2)))

            {
                Console.WriteLine("Empréstimo não concedido.");
            }

            else 
            {
                Console.WriteLine("Emprestimo concedido.");
            }

            #endregion exer 13

            #endregion Lista 01
        }
    }

}


