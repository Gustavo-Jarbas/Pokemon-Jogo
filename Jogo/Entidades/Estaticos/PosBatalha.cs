using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo.Entidades.Estaticos
{
    class PosBatalha
    {
        public static int Menu() // APOS CADA BATALHA/FASE SERA INICIALIZADA ESSA FUNÇÃO. (ainda em construção)
        {
            Console.WriteLine("[1] - Ir para a proxima batalha");
            Console.WriteLine("[2] - Pokedex");
            Console.WriteLine("[3] - Comprar na loja");
            Console.Write("R: ");
            int resposta = int.Parse(Console.ReadLine());

            return resposta;
        }
    }
}
