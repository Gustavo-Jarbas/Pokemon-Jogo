using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo.Entidades.Historia;
using Jogo.Entidades.Treinador;
using Jogo.Entidades.Batalha;
using Jogo.Entidades.Estaticos;
using Jogo.Entidades.Historia.Fases.Inimigos;

namespace Jogo.Entidades.Estaticos
{
    class PosBatalha
    {
        public static int Menu() // APOS CADA BATALHA/FASE SERA INICIALIZADA ESSA FUNÇÃO. (ainda em construção)
        {
            Console.Clear();
        
            Console.WriteLine("\n\n[1] - Ir para a proxima batalha");
            Console.WriteLine("[2] - Pokedex");
            Console.WriteLine("[3] - Comprar na loja");
            Console.Write("R: ");
            int resposta = int.Parse(Console.ReadLine());

            return resposta;
        }


        public static void Executar()
        {
            int prox = 1;
            do
            {
                int r = PosBatalha.Menu();

                if (r == 1)
                {
                    prox = 0;
                    EscolhaPokemonBatalha();
                }
                if (r == 2)
                {
                    HistoriaClass.jogador.Pokedex();
                   
                }
                if (r == 3)
                {
                    Loja();
                }
            } while (prox == 1);
        }

        public static void EscolhaPokemonBatalha()
        {
            Console.WriteLine("Escolha qual pokemon você deseja ");
            HistoriaClass.jogador.MeusPokemon();
            Console.Write("R:");
            int pokEscolhido = int.Parse(Console.ReadLine());
            HistoriaClass.jogador.PokemonEscolhido = HistoriaClass.jogador.Pokemons[pokEscolhido];

        }

        public static void Loja()
        {
            int comprarNovamente;
            do
            {
                Console.Clear();
                Dinheiro.ImprimirDinheiro(HistoriaClass.jogador);
                Console.WriteLine("|-------------------LOJA-------------------|");
                Console.WriteLine("| [1] - (5R$) 3x Pokeball                  | ");
                Console.WriteLine("| [2] - (5R$) 3x Poções 5 de vida          |");
                Console.WriteLine("|------------------------------------------|");
                Console.Write("R:");
                int itemComprado = int.Parse(Console.ReadLine());

                if (itemComprado == 1)
                {
                    if (HistoriaClass.jogador.Dinheiro >= 5)
                    {
                        HistoriaClass.jogador.PokeBalls += 3;
                        HistoriaClass.jogador.Dinheiro -= 5;
                    }
                    else
                    {
                        Console.WriteLine("Seu caloteiro, você não tem dinheiro para comprar essas pokeballs!");
                    }
                }
                if (itemComprado == 2)
                {
                    if (HistoriaClass.jogador.Dinheiro >= 5)
                    {
                        HistoriaClass.jogador.Potion += 3;
                        HistoriaClass.jogador.Dinheiro -= 5;
                    }
                    else
                    {
                        Console.WriteLine("Seu caloteiro, você não tem dinheiro para comprar essas pokeballs!");
                    }
                }
                Console.Clear();

                Console.WriteLine("Gostaria de comprar mais alguma coisa?");
                Console.WriteLine("[1] - SIM                    [2] - NÃO");
                Console.Write("R: ");
                comprarNovamente = int.Parse(Console.ReadLine());

            } while (comprarNovamente == 1);
        }
    }
}
