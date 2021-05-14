using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo.Entidades.Treinador;
using Jogo.Entidades.Batalha;
using Jogo.Entidades.Estaticos;
using Jogo.Entidades.Historia.Fases.Inimigos;

namespace Jogo.Entidades.Historia.Fases
{
    class Fase1
    {
        TreinadorClass Jogador;//isso daq vai ser padrão em todas praticamente
        TreinadorClass Vencedor;
        int backupPocao;
        int backupPokeballs;
        public Fase1(TreinadorClass jogador1)
        {
            Jogador = jogador1; 
        }


        public TreinadorClass Executar() 
        {
            Musicas.TocarMusica(1);
            Inimigo1 inimigo = new Inimigo1();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"\n{inimigo.Nome}: ");
            Console.ResetColor();
            Textos.ImprimirTextos($"\nOlá {Jogador.Nome}, tudo bem?\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"\n\nVocê: ");
            Console.ResetColor();
            Textos.ImprimirTextos("\nOpa tudo bem parceiro e você?\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"\n{inimigo.Nome}: ");
            Console.ResetColor();
            Textos.ImprimirTextos($"\nTudo belza, oque voce acha de uma batalha?\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"\n\nVocê: ");
            Console.ResetColor();
            Textos.ImprimirTextos("\nBora, quem perder passa todo o money :D\n");




            int revanche;

            do 
            {
                revanche = 2;

                Console.Clear();

                backupPocao = Jogador.Potion;
                backupPokeballs = Jogador.PokeBalls;

                BatalhaClass batalha = new BatalhaClass(Jogador, inimigo);

                Vencedor = batalha.IniciarBatalha();

                Console.Clear();

                if (Vencedor.Nome == inimigo.Nome)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"\nP{inimigo.Nome}");
                    Console.ResetColor();
                    Textos.ImprimirTextos("\n\n\nParabéns seu perdedor, voce acaba de perder essa batalha. :'(\n");
                    Console.Write("\n\nMas não fique triste pq vou te dar mais uma chance, deseja continuar?" +
                    "\n\n1 - Tentar novamente               2 - Desistir da vida \n" +
                    "\nR:");
                    revanche = int.Parse(Console.ReadLine());

                    if (revanche == 1)
                    {

                        Jogador.Potion = backupPocao;
                        Jogador.PokeBalls = backupPokeballs;

                    }
                    else
                    {
                        System.Environment.Exit(1);
                    }
                }
            } while (revanche != 2);


            return Vencedor;
        }

    }
}
