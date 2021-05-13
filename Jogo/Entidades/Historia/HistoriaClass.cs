using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo.Entidades.Historia.Fases;
using Jogo.Entidades.Treinador;
using Jogo.Entidades.Historia.Introducao;
using Jogo.Entidades.Estaticos;

namespace Jogo.Entidades.Historia
{
    class HistoriaClass
    {
        TreinadorClass jogador = new TreinadorClass();
        IntroducaoClass introducao = new IntroducaoClass();

        
        Fase0 fase0;
        Fase1 fase1;
        Fase2 fase2;
        Fase3 fase3;
        Fase4 fase4;
        Fase5 fase5;

        //Console.WriteLine("[1] - Ir para a proxima batalha");
        //Console.WriteLine("[2] - Pokedex");
        //Console.WriteLine("[3] - Comprar na loja");

        public void IniciarHistoria()
        {
            string jogadornome = jogador.Nome;

            jogador = introducao.IniciarIntroducao();

            fase0 = new Fase0(jogador);
            fase0.Executar();

            //------------------------------------------------
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
                    jogador.Pokedex();
                    Console.ReadKey();
                }
                if (r == 3)
                {
                    Loja();
                }
            } while (prox == 1);
            

            fase1 = new Fase1(jogador);
            fase1.Executar();
            //----------------------------------------------

           


        }

        public void EscolhaPokemonBatalha()
        {
            Console.WriteLine("Escolha qual pokemon você deseja ");
            jogador.MeusPokemon();
            Console.Write("R: ");
            int pokEscolhido = int.Parse(Console.ReadLine());
            jogador.PokemonEscolhido = jogador.Pokemons[pokEscolhido];

        }

        public void Loja()
        {
            int comprarNovamente;
            do
            {
                Console.Clear();
                Dinheiro.ImprimirDinheiro(jogador);
                Console.WriteLine("|-------------------LOJA-------------------|");
                Console.WriteLine("| [1] - (5R$) 3x Pokeball                  | ");
                Console.WriteLine("| [2] - (5R$) 3x Poções 5 de vida          |");
                Console.WriteLine("|------------------------------------------|");
                Console.WriteLine("R: ");
                int itemComprado = int.Parse(Console.ReadLine());

                if (itemComprado == 1)
                {
                    if (jogador.Dinheiro >= 5)
                    {
                        jogador.PokeBalls += 3;
                        jogador.Dinheiro -= 5;
                    }
                    else
                    {
                        Console.WriteLine("Seu caloteiro, você não tem dinheiro para comprar essas pokeballs!");
                    }
                }
                if (itemComprado == 2)
                {
                    if (jogador.Dinheiro >= 5)
                    {
                        jogador.Potion += 3;
                        jogador.Dinheiro -= 5;
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
