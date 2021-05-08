using System;
using System.Media;
using Jogo.Entidades;
using Jogo.Entidades.Enums;
using Jogo.Entidades.Pokemons;
using Jogo.Entidades.FuncoesGame;
using System.Threading.Tasks;
using System.Threading;


namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            

   

            Historia novojogo = new Historia();
            novojogo.SolicitandoDadosJogador();
            novojogo.Apresentacao();
            novojogo.PrimeiraFase();
           
        }
    }
}
