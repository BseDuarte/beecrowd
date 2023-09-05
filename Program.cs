using System;
using System.Collections;

namespace Lanche1038
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double soma;
            double valor = 0;
            Console.WriteLine("Seja bem-vindo ao gordão lanches.bases.net!");
            Console.Write("Insira o seu lanche mortal:");
            Console.WriteLine();


            Console.WriteLine("1 - Cachorro Quente R$4,00");
            Console.WriteLine("2 - X-Salada R$4,50");
            Console.WriteLine("3 - X-Bacon R$5,00");
            Console.WriteLine("4 - Torrada Simples R$2,00");
            Console.WriteLine("5 - Refrigerante R$1,50");

            int pedido = int.Parse(Console.ReadLine());

            /*Console.WriteLine("Deseja algo mais?");
            Console.Write("Sim/Nao");
            const bool Sim = true;
            const bool Nao = false;

            while (Sim == true)
            {
                int pedido = int.Parse(Console.ReadLine());

                Console.WriteLine("Deseja algo mais?");
                Console.Write("Sim/Nao");

                bool more = bool.Parse(Console.ReadLine());
            }*/
             

            Console.WriteLine("Insira a quantidade desejada: ");
            int quantidade = int.Parse(Console.ReadLine());



            if (pedido == 1)
            {
                valor = 4.00;
            }
            else if (pedido == 2)
            {
                valor = 4.50;
            }
            else if (pedido == 3)
            {
                valor = 5.00;
            }
            else if (pedido == 4)
            {
                valor = 2.00;
            }
            else if (pedido == 5)
            {
                valor = 1.50;
            }

            soma = valor * quantidade;
            Console.WriteLine("Total à pagar: R$" + soma.ToString("F2"));
            //Console.WriteLine("VOCÊ GANHOU UMA PORÇÃO DE DIABETES DE BRINDE!");
        }
    }
}