using System;
using System.Collections.Generic;
using Jogo.Entidades;
using Jogo.Entidades.Enums;
using Jogo.Entidades.Pokemons;

namespace Jogo.Entidades
{
    class Batalha
    {
        public Treinador Jogador1;
        public Treinador Jogador2;
        public Treinador Vencedor;

        public Batalha(Treinador jogador1, Treinador jogador2)
        {
            this.Jogador1 = jogador1;
            this.Jogador2 = jogador2;
        }

        public Treinador IniciarBatalha()
        {
            string PokemonSelvagem = Jogador2.Pokemons[0].Nome;
            int PokemonSelvagemVida = Jogador2.Pokemons[0].HpTotal;

            string SeuPokemon = Jogador1.Pokemons[0].Nome;
            int SeuPokemonVida = Jogador1.Pokemons[0].HpTotal;

            string SeuPokemonAtaqueTxt = Jogador1.Pokemons[0].AtaqueBasicoTxt;
            int SeuPokemonAtaqueDano = Jogador1.Pokemons[0].AtaqueBasico;

            string SeuPokemonEspecialTxt = Jogador1.Pokemons[0].EspecialTxt;
            int SeuPokemonEspecialDano = Jogador1.Pokemons[0].Especial;

            do
            {
                int ataque;

                Console.WriteLine($"Pokemon Selvagem: {PokemonSelvagem}");
                Console.WriteLine($"Vida: {PokemonSelvagemVida}");
                Console.WriteLine("");
                Console.WriteLine($"Seu Pokemon: {SeuPokemon}");
                Console.WriteLine($"Vida: {SeuPokemonVida}");
                Console.WriteLine("");
                Console.WriteLine("Seus ataques são: ");
                Console.WriteLine($"[1] - {SeuPokemonAtaqueTxt}: {SeuPokemonAtaqueDano} de Dano");
                Console.WriteLine($"[2] - {SeuPokemonEspecialTxt}: {SeuPokemonEspecialDano} de Dano");
                Console.Write("Digite o numero do ataque escolhido: ");
                ataque = int.Parse(Console.ReadLine());

                Console.Clear();

                if (ataque == 1)
                {
                    Console.WriteLine($"{SeuPokemon} atacou {PokemonSelvagem} com o ataque {SeuPokemonAtaqueTxt} o causando {SeuPokemonAtaqueDano} de dano");
                    PokemonSelvagemVida -= SeuPokemonAtaqueDano;
                    Console.WriteLine($"{PokemonSelvagem} está com {PokemonSelvagemVida} de vida");
                }

                if(ataque == 2)
                {
                    Console.WriteLine($"{SeuPokemon} atacou {PokemonSelvagem} com o ataque Especial {SeuPokemonEspecialTxt} o causando {SeuPokemonEspecialDano} de dano");
                    PokemonSelvagemVida -= SeuPokemonEspecialDano;
                    Console.WriteLine($"{PokemonSelvagem} está com {PokemonSelvagemVida} de vida");
                }


            } while (SeuPokemonVida > 0 && PokemonSelvagemVida > 0);

            Vencedor = VerificarVencedor(SeuPokemonVida, PokemonSelvagemVida);

            return Vencedor;
        }

        public Treinador VerificarVencedor(int seuPokemonVida, int pokemonSelvagemVida)
        {
            return (seuPokemonVida > 0) ? Jogador1 : Jogador2; //Expressão Condicional Ternária
        }

}
}
