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
            Treinador treinador2 = new Treinador("Jarbas");

            Pokemon pokemons = new Pokemon();


            treinador.Pokemons.Add(charmander);
            treinador2.Pokemons.Add(bulbassauro);

            Batalha batalha = new Batalha(treinador, treinador2);
            Treinador vencedor = batalha.IniciarBatalha();

            Console.WriteLine($"O treinador {vencedor.Nome} e seu {vencedor.Pokemons[0].Nome} ganharam!!!");

            //treinador.Pokedex();

        }
    }
}
