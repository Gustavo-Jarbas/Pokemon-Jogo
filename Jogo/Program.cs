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
            

   

            Historia novojogo = new Historia();
            novojogo.Menu();
            novojogo.Introducao();
            novojogo.PrimeiraFase();
            


        }
    }
}
