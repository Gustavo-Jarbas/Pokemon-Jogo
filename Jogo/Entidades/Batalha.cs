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

        public int pok1IntervaloAtaque2 = 0; 
        public int pok2IntervaloAtaque2 = 0; 


        public Batalha(Treinador jogador1, Treinador jogador2)
        {
            this.Jogador1 = jogador1;
            this.Jogador2 = jogador2;
        }

        public Treinador IniciarBatalha()
        {
            Game.Musicas(2);

            string SeuPokemon = Jogador1.Pokemons[0].Nome;
            pok1Vida = Jogador1.Pokemons[0].HpAtual;

            string SeuPokemonAtaqueTxt = Jogador1.Pokemons[0].AtaqueBasicoTxt;
            pok1DanoNormal = Jogador1.Pokemons[0].AtaqueBasico;

            string SeuPokemonEspecialTxt = Jogador1.Pokemons[0].EspecialTxt;
            pok1DanoEspecial = Jogador1.Pokemons[0].Especial;



            string PokemonSelvagem = Jogador2.Pokemons[0].Nome;
            pok2Vida = Jogador2.Pokemons[0].HpAtual;

            string PokemonSelvagemAtaqueTxt = Jogador2.Pokemons[0].AtaqueBasicoTxt;
            pok2DanoNormal = Jogador2.Pokemons[0].AtaqueBasico;

            string PokemonSelvagemEspecialTxt = Jogador2.Pokemons[0].EspecialTxt;
            pok2DanoEspecial = Jogador2.Pokemons[0].Especial;

            do
            {
                int ataque;
                int menuBatalha;

                Console.WriteLine($"Pokemon Inimigo: {PokemonSelvagem}");
                Console.WriteLine($"Vida: {pok2Vida}");
                Console.WriteLine("");
                Console.WriteLine($"Seu Pokemon: {SeuPokemon}");
                Console.WriteLine($"Vida: {pok1Vida}");
                Console.WriteLine("");
                Console.WriteLine("[1] - Ataques");
                Console.WriteLine("[2] - Itens");
                Console.WriteLine("Digite o numero da opção: ");
                menuBatalha = int.Parse(Console.ReadLine());
                if(menuBatalha == 1)
                {

                    Console.WriteLine("Seus ataques são: ");
                    Console.WriteLine($"[1] - {SeuPokemonAtaqueTxt}: {pok1DanoNormal} de Dano");
                    Console.WriteLine($"[2] - {SeuPokemonEspecialTxt}: {pok1DanoEspecial} de Dano");
                    Console.Write("Digite o numero do ataque escolhido: ");
                    ataque = int.Parse(Console.ReadLine());

                    Console.Clear();

                    if (ataque == 1)
                    {
                        if(pok1IntervaloAtaque2 % 2 == 1)
                        {
                            pok1IntervaloAtaque2++;
                        }
                        AtaquePokemon(true, SeuPokemon, PokemonSelvagem, SeuPokemonAtaqueTxt, pok1DanoNormal);
                    }
                    else if (ataque == 2 && pok1IntervaloAtaque2 % 2 == 0)
                    {
                        pok1IntervaloAtaque2++;
                        AtaquePokemon(true, SeuPokemon, PokemonSelvagem, SeuPokemonEspecialTxt, pok1DanoEspecial);
                    }
                    else if (pok1IntervaloAtaque2 % 2 == 1)
                    {
                        pok1IntervaloAtaque2++;
                        Console.Clear();
                        Console.WriteLine("Habilidade em intervalo!");
                        Console.WriteLine("");
                        Console.WriteLine("Seus ataques são: ");
                        Console.WriteLine($"[1] - {SeuPokemonAtaqueTxt}: {pok1DanoNormal} de Dano");
                        Console.Write("Digite o numero do ataque escolhido: ");
                        ataque = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (ataque == 1)
                        {
                            AtaquePokemon(true, SeuPokemon, PokemonSelvagem, SeuPokemonAtaqueTxt, pok1DanoNormal);
                        }

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
                }
                else
                {
                    Console.WriteLine("[1] - "+ Jogador1.Potion +"x Poção de cura (+5) ");
                    Console.WriteLine("[2] - "+ Jogador1.PokeBalls +"x Pokeball ");
                    Console.Write("Digite a opção escolhida: ");
                    int respostaItem = int.Parse(Console.ReadLine());
                    if(respostaItem == 1 && Jogador1.Potion != 0)
                    {
                        if(pok1Vida + 5 > Jogador1.Pokemons[0].HpTotal)
                        {
                            pok1Vida = Jogador1.Pokemons[0].HpTotal;
                        }
                        else
                        {
                            pok1Vida += 5;
                        }

                        Jogador1.Potion--;
                    }
                    else if (respostaItem == 2 && Jogador1.PokeBalls != 0)
                    {
                        if (pok2Vida < (Jogador2.Pokemons[0].HpTotal - (Jogador2.Pokemons[0].HpTotal * 0.6))) // se a vida do pokemon for menor que 60% da vida maxima dele, então pode ter chance de capturar
                        {
                            Random pokeb = new Random(DateTime.Now.Millisecond);
                            int captura = pokeb.Next(1, 3);

                            if( captura == 1)
                            {
                                Jogador1.Pokemons.Add(Jogador2.Pokemons[0]);
                                Console.WriteLine($"O Pokemon {PokemonSelvagem} foi capturado com sucesso.");
                                Vencedor = Jogador1;
                                return Vencedor;
                            }

                            Jogador1.PokeBalls--;

                            Console.Clear();
                            continue;
                        }
                        
                    }
                }
                
            } while (pok1Vida > 0 && pok2Vida > 0);

            Vencedor = VerificarVencedor(pok1Vida, pok2Vida);
            Jogador1.Dinheiro += 100;
            return Vencedor;
        }

        public void AtaquePokemon(bool qualPokemon, string pok1, string pok2, string pokAtaqueTxt, int pokAtaqueDano)
        {
            
            Console.WriteLine($"{pok1} atacou {pok2} com o ataque {pokAtaqueTxt} o causando {pokAtaqueDano} de dano");
            if (qualPokemon)
            {
                Console.Beep(300, 500);
                pok2Vida -= pokAtaqueDano;
            }
            else
            {
                Console.Beep(300, 500);
                pok1Vida -= pokAtaqueDano;
            }

        }

        public Treinador VerificarVencedor(int seuPokemonVida, int pokemonSelvagemVida)
        {
            return (seuPokemonVida > 0) ? Jogador1 : Jogador2; //Expressão Condicional Ternária
        }

}
}
