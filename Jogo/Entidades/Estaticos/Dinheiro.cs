using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Jogo.Entidades.Treinador;

namespace Jogo.Entidades.Estaticos
{
    class Dinheiro
    {


        public static void ImprimirDinheiro(TreinadorClass treinador)
        {


            for (int din = 0; din <= treinador.Dinheiro; din++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"                                                                                                   |R$ {din}|");
                Thread.Sleep(30);

            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
