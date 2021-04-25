using System;
using Jogo.Entidades;
using Jogo.Entidades.Enums;
using Jogo.Entidades.Pokemons;


namespace Jogo
{
    class Program
    {
        static void Main(string[] args)
        {

            Pokemon charmander = new Charmander();
            Pokemon bulbassauro = new Bulbassauro();
            Pokemon squirtle = new Squirtle();

            Treinador treinador = new Treinador("Gustavo");
            Pokemon pokemons = new Pokemon();

         
            treinador.Pokemons.Add(charmander);
            treinador.Pokemons.Add(bulbassauro);
            treinador.Pokemons.Add(squirtle);

            treinador.Pokedex();
        }
    }
}
