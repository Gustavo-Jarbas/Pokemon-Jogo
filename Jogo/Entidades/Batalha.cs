using System;
using System.Collections.Generic;
using Jogo.Entidades;
using Jogo.Entidades.Enums;
using Jogo.Entidades.Pokemons;
using System.Media;
using Jogo.Entidades.FuncoesGame;




namespace Jogo.Entidades
{
    class Batalha
    {
        public Treinador Jogador1;
        public Treinador Jogador2;
        public Treinador Vencedor;

        public int pok1Vida;
        public int pok1DanoNormal;
        public int pok1DanoEspecial;

        public int pok2Vida;
        public int pok2DanoNormal;
        public int pok2DanoEspecial;

        public int pok1IntervaloAtaque2 = 0; // ainda não usei
        public int pok2IntervaloAtaque2 = 0; // ainda não usei


        public Batalha(Treinador jogador1, Treinador jogador2)
        {
            this.Jogador1 = jogador1;
            this.Jogador2 = jogador2;
        }

        public Treinador IniciarBatalha()
        {
            Game.Musicas(2);

            string SeuPokemon = Jogador1.Pokemons[0].Nome;
            pok1Vida = Jogador1.Pokemons[0].HpTotal;

            string SeuPokemonAtaqueTxt = Jogador1.Pokemons[0].AtaqueBasicoTxt;
            pok1DanoNormal = Jogador1.Pokemons[0].AtaqueBasico;

            string SeuPokemonEspecialTxt = Jogador1.Pokemons[0].EspecialTxt;
            pok1DanoEspecial = Jogador1.Pokemons[0].Especial;



            string PokemonSelvagem = Jogador2.Pokemons[0].Nome;
            pok2Vida = Jogador2.Pokemons[0].HpTotal;

            string PokemonSelvagemAtaqueTxt = Jogador2.Pokemons[0].AtaqueBasicoTxt;
            pok2DanoNormal = Jogador2.Pokemons[0].AtaqueBasico;

            string PokemonSelvagemEspecialTxt = Jogador2.Pokemons[0].EspecialTxt;
            pok2DanoEspecial = Jogador2.Pokemons[0].Especial;

            do
            {
                int ataque;

                Console.WriteLine($"Pokemon Inimigo: {PokemonSelvagem}");
                Console.WriteLine($"Vida: {pok2Vida}");
                Console.WriteLine("");
                Console.WriteLine($"Seu Pokemon: {SeuPokemon}");
                Console.WriteLine($"Vida: {pok1Vida}");
                Console.WriteLine("");
                Console.WriteLine("Seus ataques são: ");
                Console.WriteLine($"[1] - {SeuPokemonAtaqueTxt}: {pok1DanoNormal} de Dano");
                Console.WriteLine($"[2] - {SeuPokemonEspecialTxt}: {pok1DanoEspecial} de Dano");
                Console.Write("Digite o numero do ataque escolhido: ");
                ataque = int.Parse(Console.ReadLine());
               
                Console.Clear();

                if(ataque == 1)
                {
                    AtaquePokemon(true, SeuPokemon, PokemonSelvagem, SeuPokemonAtaqueTxt, pok1DanoNormal);
                }
                else if (ataque == 2 && pok1IntervaloAtaque2 % 2 == 0)
                {
                    pok1IntervaloAtaque2++;
                    AtaquePokemon(true, SeuPokemon, PokemonSelvagem, SeuPokemonAtaqueTxt, pok1DanoEspecial);
                }
                else
                {
                    pok1IntervaloAtaque2++;
                    Console.WriteLine("Habilidade em intervalo!");
                }

                Random rnd = new Random(DateTime.Now.Millisecond);
                int ataqueSelvagem = rnd.Next(1, 3);

                if (ataqueSelvagem == 1)
                {
                    AtaquePokemon(false, PokemonSelvagem, SeuPokemon, PokemonSelvagemAtaqueTxt, pok2DanoNormal);
                }
                else if (ataqueSelvagem == 2 && pok2IntervaloAtaque2 % 2 == 0)
                {
                    pok2IntervaloAtaque2++;
                    AtaquePokemon(false, PokemonSelvagem, SeuPokemon, PokemonSelvagemEspecialTxt, pok2DanoEspecial);
                }
                else
                {
                    pok2IntervaloAtaque2++;
                    Console.WriteLine("Habilidade em intervalo!");
                }

            } while (pok1Vida > 0 && pok2Vida > 0);

            Vencedor = VerificarVencedor(pok1Vida, pok2Vida);

            return Vencedor;
        }

        public void AtaquePokemon(bool qualPokemon, string pok1, string pok2, string pokAtaqueTxt, int pokAtaqueDano)
        {
            
            Console.WriteLine($"{pok1} atacou {pok2} com o ataque {pokAtaqueTxt} o causando {pokAtaqueDano} de dano");
            if (qualPokemon)
            {
                pok2Vida -= pokAtaqueDano;
            }
            else
            {   
                pok1Vida -= pokAtaqueDano;
            }

        }

        public Treinador VerificarVencedor(int seuPokemonVida, int pokemonSelvagemVida)
        {
            return (seuPokemonVida > 0) ? Jogador1 : Jogador2; //Expressão Condicional Ternária
        }

}
}
