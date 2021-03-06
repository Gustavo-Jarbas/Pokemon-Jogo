using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jogo.Entidades.Estaticos
{
    class Textos
    {
        public static void ImprimirTextos(string texto)
        {
            foreach (var letra in texto)
            {
                Console.Write(letra);
                Thread.Sleep(40);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Press qualquer tecla ...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Write("                         ");
        }

        public static void ImprimirTextosSemPause(string texto)
        {
            foreach (var letra in texto)
            {
                Console.Write(letra);
                Thread.Sleep(40);
            }
            Console.Write("                         ");
        }

        public static void ImprimirTextosErro(string texto)
        {
            foreach (var letra in texto)
            {
                Console.Write(letra);
                Thread.Sleep(40);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Pressione qualquer tecla ...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Write("                         ");
        }
    }
}
