using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Jogo.Entidades.Enums;
using Jogo.Entidades.Pokemons;
using System.Media;
using Jogo.Entidades.FuncoesGame;
using Jogo.Entidades.Fases.Inimigos;
using Jogo.Entidades.Fases;
using Jogo.Entidades;





namespace Jogo.Entidades.Fases
{
     class Fase1 
    {

        public static void Executar()
        {
            Console.Clear();
            Game.ImprimirDinheiro(Historia.Dinheiro);
            Game.ImprimirTextos($"Você escolheu o tipo de Pokemon de {Historia.PokemonEscolhido.TipoPokemon}, essa foi uma boa e fabulosa escolha" +
                    $"\nCom essa especialidade o nome de seu Pokemon é {Historia.PokemonEscolhido.Nome} \n");
            Game.ImprimirTextos("\n\nRepare que ao lado direito está seu dinheiro e conforme você ir vencendo batalhas vai ganhando mais e" +
            "\nutilizqar para comprar pokebolas e poçoes de cura\n");
            Game.ImprimirTextos("\n\n\nEntao... oque você acha de iniciarmos com um breve duelo para testar suas habilidades? \n\n");

            Game.ImprimirTextos("\n\n\nTem um cara maluquinho da cabeça que está atacando a vila, vamos lá acabar com ele?\n\n");


            Console.Clear();

            
            Treinador treinador = new Treinador(Historia.NomeJogador); ;
            Inimigo1 inimigo1 = new Inimigo1();
            Pokemon DoInimigo = new Bulbassauro();

            Pokemon pokemons = new Pokemon();
            treinador.Pokemons.Add(Historia.PokemonEscolhido); ;
            inimigo1.Pokemons.Add(DoInimigo);
            bool proximafase = false;

            Batalha batalha;
            Treinador vencedor;

            do
            {
                Console.Clear();
                batalha = new Batalha(treinador, inimigo1);

                vencedor = batalha.IniciarBatalha();
                Console.WriteLine($"O treinador {vencedor.Nome} e seu {vencedor.Pokemons[0].Nome} ganharam!!!");

                if (vencedor.Nome == inimigo1.Nome){
                    proximafase = false;
                    Console.Clear();

                    Game.ImprimirTextos("\n\n\nParabéns seu perdedor, voce acaba de perder essa batalha. D:" +
                        "\n\nMas não fique triste pq vamos te dar mais uma chance, deseja continuar?" +
                        "\n\n1 - SIM               2 - NAO \n");
                        Console.Write("\nR:");
                    int tentarnovamente = (Console.Read());

                    if (tentarnovamente == 2)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        proximafase = false;
                    }
                                            
                
                }
                else
                {
                    proximafase = true;
                }
            } while (proximafase == false);
        }
    }
}
