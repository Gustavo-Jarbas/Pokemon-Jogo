using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo.Entidades.Treinador;
using Jogo.Entidades.Estaticos;

namespace Jogo.Entidades.Batalha
{
    class BatalhaClass
    {
        public TreinadorClass Jogador1;
        public TreinadorClass Jogador2;
        public TreinadorClass Vencedor;

        public int pok1IntervaloAtaque2 = 0;
        public int pok2IntervaloAtaque2 = 0;

        public BatalhaClass()
        {

        }

        public BatalhaClass(TreinadorClass jogador1, TreinadorClass jogador2)
        {
            this.Jogador1 = jogador1;
            this.Jogador2 = jogador2;
        }

        public TreinadorClass IniciarBatalha()
        {
            Musicas.TocarMusica(2);
            Jogador1.PokemonEscolhido.HpAtual = Jogador1.PokemonEscolhido.HpTotal;

            do
            {
                int ataque;
                int menuBatalha = 0;
                Console.WriteLine($"Nome do inimigo: {Jogador2.Nome}");
                Console.WriteLine($"Pokemon Inimigo: {Jogador2.Pokemons[0].Nome}");
                Console.WriteLine($"Vida: {Jogador2.Pokemons[0].HpAtual}");
                Console.WriteLine("");
                Console.WriteLine($"Seu nome: {Jogador1.Nome}");
                Console.WriteLine($"Seu Pokemon: {Jogador1.PokemonEscolhido.Nome}");
                Console.WriteLine($"Vida: {Jogador1.PokemonEscolhido.HpAtual}");
                Console.WriteLine("");
                Console.WriteLine("[1] - Ataques");
                Console.WriteLine("[2] - Itens");
                Console.WriteLine("Digite o numero da opção: ");
                try
                {
                    menuBatalha = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine($"Nome do inimigo: {Jogador2.Nome}");
                    Console.WriteLine($"Pokemon Inimigo: {Jogador2.Pokemons[0].Nome}");
                    Console.WriteLine($"Vida: {Jogador2.Pokemons[0].HpAtual}");
                    Console.WriteLine("");
                    Console.WriteLine($"Seu nome: {Jogador1.Nome}");
                    Console.WriteLine($"Seu Pokemon: {Jogador1.PokemonEscolhido.Nome}");
                    Console.WriteLine($"Vida: {Jogador1.PokemonEscolhido.HpAtual}");
                    Console.WriteLine("");
                    Console.WriteLine("[1] - Ataques");
                    Console.WriteLine("[2] - Itens");
                    Console.WriteLine("Digite o numero da opção: ");
                    menuBatalha = Convert.ToInt32(Console.ReadLine());
                }

                if (menuBatalha == 1)
                {

                    Console.WriteLine("Seus ataques são: ");
                    Console.WriteLine($"[1] - {Jogador1.PokemonEscolhido.AtaqueBasicoTxt}: {Jogador1.PokemonEscolhido.AtaqueBasico} de Dano");
                    Console.WriteLine($"[2] - {Jogador1.PokemonEscolhido.EspecialTxt}: {Jogador1.PokemonEscolhido.Especial} de Dano");
                    Console.Write("Digite o numero do ataque escolhido: ");
                    ataque = int.Parse(Console.ReadLine());

                    Console.Clear();

                    if (ataque == 1)
                    {
                        if (pok1IntervaloAtaque2 % 2 == 1)
                        {
                            pok1IntervaloAtaque2++;
                        }
                        AtaquePokemon(true, Jogador1.PokemonEscolhido.Nome, Jogador2.Pokemons[0].Nome, Jogador1.PokemonEscolhido.AtaqueBasicoTxt, Jogador1.PokemonEscolhido.AtaqueBasico);
                    }
                    else if (ataque == 2 && pok1IntervaloAtaque2 % 2 == 0)
                    {
                        pok1IntervaloAtaque2++;
                        AtaquePokemon(true, Jogador1.PokemonEscolhido.Nome, Jogador2.Pokemons[0].Nome, Jogador1.PokemonEscolhido.EspecialTxt, Jogador1.PokemonEscolhido.Especial);
                    }
                    else if (pok1IntervaloAtaque2 % 2 == 1)
                    {
                        pok1IntervaloAtaque2++;
                        Console.Clear();
                        Console.WriteLine("Habilidade em intervalo!");
                        Console.WriteLine("");
                        Console.WriteLine("Seus ataques são: ");
                        Console.WriteLine($"[1] - {Jogador1.PokemonEscolhido.AtaqueBasicoTxt}: {Jogador1.PokemonEscolhido.AtaqueBasico} de Dano");
                        Console.Write("Digite o numero do ataque escolhido: ");
                        ataque = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (ataque == 1)
                        {
                            AtaquePokemon(true, Jogador1.PokemonEscolhido.Nome, Jogador2.Pokemons[0].Nome, Jogador1.PokemonEscolhido.AtaqueBasicoTxt, Jogador1.PokemonEscolhido.AtaqueBasico);
                        }

                    }

                    Random rnd = new Random(DateTime.Now.Millisecond);
                    int ataqueSelvagem = rnd.Next(1, 3);

                    if (ataqueSelvagem == 1)
                    {

                        AtaquePokemon(false, Jogador2.Pokemons[0].Nome, Jogador1.PokemonEscolhido.Nome, Jogador2.Pokemons[0].AtaqueBasicoTxt, Jogador2.Pokemons[0].AtaqueBasico);
                    }
                    else if (ataqueSelvagem == 2 && pok2IntervaloAtaque2 % 2 == 0)
                    {
                        pok2IntervaloAtaque2++;
                        AtaquePokemon(false, Jogador2.Pokemons[0].Nome, Jogador1.PokemonEscolhido.Nome, Jogador2.Pokemons[0].EspecialTxt, Jogador2.Pokemons[0].Especial);
                    }
                    else
                    {
                        pok2IntervaloAtaque2++;
                        Console.WriteLine("Habilidade em intervalo!");
                    }
                }
                else
                {
                    Console.WriteLine("[1] - " + Jogador1.Potion + "x Poção de cura (+5) ");
                    Console.WriteLine("[2] - " + Jogador1.PokeBalls + "x Pokeball ");
                    Console.Write("Digite a opção escolhida: ");
                    int respostaItem = int.Parse(Console.ReadLine());

                    if (respostaItem == 1 && Jogador1.Potion > 0)
                    {
                        if (Jogador1.PokemonEscolhido.HpAtual + 5 > Jogador1.PokemonEscolhido.HpTotal)
                        {
                            Jogador1.PokemonEscolhido.HpAtual = Jogador1.PokemonEscolhido.HpTotal;
                        }
                        else
                        {
                            Jogador1.PokemonEscolhido.HpAtual += 5;
                        }

                        --Jogador1.Potion;
                    }

                    if (respostaItem == 1 && Jogador1.Potion < 0)
                    {
                        Textos.ImprimirTextosErro("\nVocê não tem poções!\n");
                    }

                    if (respostaItem == 2 && Jogador1.PokeBalls > 0)
                    {
                        if (Jogador2.Pokemons[0].HpAtual < (Jogador2.Pokemons[0].HpTotal - (Jogador2.Pokemons[0].HpTotal * 0.6))) // se a vida do pokemon for menor que 60% da vida maxima dele, então pode ter chance de capturar
                        {
                            Random pokeb = new Random(DateTime.Now.Millisecond);
                            int captura = pokeb.Next(1, 3);

                            --Jogador1.PokeBalls;

                            if (captura == 1)
                            {
                                Jogador1.Pokemons.Add(Jogador2.Pokemons[0]);
                                Textos.ImprimirTextosErro($"\nO Pokemon {Jogador2.Pokemons[0].Nome} foi capturado com sucesso.\n");
                                Vencedor = Jogador1;
                                Jogador1.Dinheiro += Jogador2.Dinheiro;

                                
                                return Vencedor;
                            }

                            
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            --Jogador1.PokeBalls;
                        }
                    }

                    if (respostaItem == 2 && Jogador1.PokeBalls <= 0)
                    {
                        Textos.ImprimirTextosErro("\nVocê não tem Pokebolas!\n");
                    }
                }

            } while (Jogador1.PokemonEscolhido.HpAtual > 0 && Jogador2.Pokemons[0].HpAtual > 0);

            Vencedor = VerificarVencedor(Jogador1.PokemonEscolhido.HpAtual, Jogador2.Pokemons[0].HpAtual);
            Jogador1.Dinheiro += Jogador2.Dinheiro;
            return Vencedor;
        }

        public void AtaquePokemon(bool qualPokemon, string pok1, string pok2, string pokAtaqueTxt, int pokAtaqueDano)
        {

            Console.WriteLine($"{pok1} atacou {pok2} com o ataque {pokAtaqueTxt} o causando {pokAtaqueDano} de dano");
            if (qualPokemon)
            {
                Console.Beep(300, 500);
                Jogador2.Pokemons[0].HpAtual -= pokAtaqueDano;
            }
            else
            {
                Console.Beep(300, 500);
                Jogador1.PokemonEscolhido.HpAtual -= pokAtaqueDano;
            }

        }

        public TreinadorClass VerificarVencedor(int seuPokemonVida, int pokemonSelvagemVida)
        {
            return (seuPokemonVida > 0) ? Jogador1 : Jogador2; //Expressão Condicional Ternária
        }
    }

}
