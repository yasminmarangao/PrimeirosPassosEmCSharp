using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idadeJoao = 18;
            string mensagemAdicional;
            bool acompanhado = true;

            if (acompanhado == true)
            {
                mensagemAdicional = "Joao esta acompanhado";
            }

            //quando é somente uma instrução não necessita das chaves. porém é importante para organização
            else
            {
                mensagemAdicional = "Joao nao esta acompanhado";
            }

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Joao pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Joao nao pode entrar.");
            }

            Console.ReadLine();

        }

    }
}