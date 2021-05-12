using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Jogo.Entidades.Enums;
using Jogo.Entidades.Pokemons;
using System.Media;
using Jogo.Entidades.FuncoesGame;
using Jogo.Entidades.Fases.Inimigos;
using Jogo.Entidades.Fases;
using Jogo.Entidades;
namespace Jogo.Entidades.Fases
{
    class Fase2
    {
        static public bool proximafase = false;


        public Fase2()
        {

        }
        public static void Executar()
        {
            Console.Clear();
                Game.ImprimirTextos("Bem vindo a fase 2 :D, falta FAZERRRRRRRR!!!!!");
            
        }
    }
}
