using System;
using System.Media;
using Jogo.Entidades;
using Jogo.Entidades.Enums;
using Jogo.Entidades.Pokemons;



namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new SoundPlayer(@"pokemon.wav");
            player.Play();

   

            Historia novojogo = new Historia();
            novojogo.DadosJogador();
            novojogo.Introducao();
            novojogo.PrimeiraFase();
            


        }
    }
}
