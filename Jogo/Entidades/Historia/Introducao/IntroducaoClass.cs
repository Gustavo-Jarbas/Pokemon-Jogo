using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo.Entidades.Estaticos;
using Jogo.Entidades.Enums;
using Jogo.Entidades.Pokemon;
using Jogo.Entidades.Pokemon.Pokemons;
using Jogo.Entidades.Treinador;

namespace Jogo.Entidades.Historia.Introducao
{
    class IntroducaoClass
    {
        public string Sexo;
        public string NomeJogador;
        public int EscolhaPokemon;
        public Tipo TipoPokemon;
        public PokemonClass PokemonEscolhido;

        public TreinadorClass IniciarIntroducao()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                    _                             \n" +
                              "        _ __   ___ | | _____ _ __ ___   ___  _ __ \n" +
                              "       | '_ \\ / _ \\| |/ / _ \\ '_ ` _ \\ / _ \\| '_ \\ \n " +
                              "      | |_) | (_) |   < __ / | | | | | (_) | | | |\n" +
                              "       | .__/ \\___/|_|\\_\\___|_| |_| |_|\\___/|_| |_| \n" +
                              "       |_|\n\n" +
                          "       _   _          _                  /\\/\\ |\\               \n" +
                          "      | | | |  _ _   (_)  _ __           \\ \\ \\//               \n" +
                          "      | |_| | | ' \\  | | |'_  \\          / o_o\\                \n" +
                          "       \\___/  |_||_| |_| |.__ /          \\____/                 \n" +
                           "                         |_|             /_\\/_\\                 \n\n\n");

            Console.ResetColor();

            Musicas.TocarMusica(1);
            Textos.ImprimirTextos("\nBem-vindo ao mundo POKEMON!\n\n" +
             "Antes de iniciarmos o game, fale me um pouco sobre voce >D\n\n\n");


            Console.Clear();
            Console.Write("\nVoce é um garoto ou uma garota?\nR:");
            Sexo = Console.ReadLine().ToUpper();
            Console.Write("\n\nMuito bem e qual seu nome?\nR:");
            NomeJogador = Console.ReadLine().ToUpper();
            Console.Write("\n\nUAUUUUUU!!!! Que lindo nome, agora escolha o tipo de pokemon que deseja iniciar\n(0)Fogo\n(1)Agua\n(2)Planta\nR:");
            EscolhaPokemon = int.Parse(Console.ReadLine());


            if (EscolhaPokemon == 0)
            {
                TipoPokemon = Tipo.Fogo;
                PokemonEscolhido = new Charmander();
            }
            if (EscolhaPokemon == 1)
            {
                TipoPokemon = Tipo.Agua;
                PokemonEscolhido = new Squirtle();
            }
            if (EscolhaPokemon == 2)
            {
                TipoPokemon = Tipo.Planta;
                PokemonEscolhido = new Bulbassauro();
            }

            TreinadorClass jogador = new TreinadorClass(NomeJogador);

            jogador.Pokemons.Add(PokemonEscolhido);
            jogador.PokemonEscolhido = PokemonEscolhido;

            return jogador;
        } 


    }
}
