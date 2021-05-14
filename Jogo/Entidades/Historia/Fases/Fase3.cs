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
    class Fase3
    {
        TreinadorClass Jogador;
        TreinadorClass Vencedor;
        int backupPocao;
        int backupPokeballs;
        public Fase3(TreinadorClass jogador)
        {
            Jogador = jogador;
        }


        public TreinadorClass Executar()
        {
            Musicas.TocarMusica(1);

            Inimigo3 james = new Inimigo3();
            Inimigo4 jassie = new Inimigo4();
            Inimigo5 meowth = new Inimigo5();

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"\n{jassie.Nome}: ");
            Console.ResetColor();
            Textos.ImprimirTextosSemPause("\nPreparem-se para a encrenca!\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"\n{james.Nome}: ");
            Console.ResetColor();
            Textos.ImprimirTextosSemPause("\nEncrenca em dobro!\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"\n{jassie.Nome}: ");
            Console.ResetColor();
            Textos.ImprimirTextosSemPause("\nPara proteger o mundo da devastação!\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"\n{james.Nome}: ");
            Console.ResetColor();
            Textos.ImprimirTextosSemPause("\nPara unir as pessoas de nossa nação!\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"\n{jassie.Nome}: ");
            Console.ResetColor();
            Textos.ImprimirTextosSemPause("\nPara denunciar os males da verdade e do amor!\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"\n{james.Nome}: ");
            Console.ResetColor();
            Textos.ImprimirTextosSemPause("\nPara estender o nosso poder às estrelas!\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"\n{jassie.Nome}: ");
            Console.ResetColor();
            Textos.ImprimirTextosSemPause("\nJessie!\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"\n{james.Nome}: ");
            Console.ResetColor();
            Textos.ImprimirTextosSemPause("\nJames!\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"\n{jassie.Nome}: ");
            Console.ResetColor();
            Textos.ImprimirTextosSemPause("\nEquipe Rocket decolando na velocidade da luz!\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"\n{james.Nome}: ");
            Console.ResetColor();
            Textos.ImprimirTextosSemPause("\nRenda - se agora ou preparem - se Para lutar! lutar! lutar!\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"\n{meowth.Nome}: ");
            Console.ResetColor();
            Textos.ImprimirTextos("\nMeowth, é isso aí!\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"\n{james.Nome}: ");
            Console.ResetColor();
            Textos.ImprimirTextos("\nSomos a equipe Rocket, e vamos roubar seu pokemon! vamos lutar agora\n");

            int revanche;

            do //isso daq vai ser padrão em todas praticamente, só mudar os numero dos inimigos.
            {
                revanche = 2;

                Console.Clear();


                backupPocao = Jogador.Potion;
                backupPokeballs = Jogador.PokeBalls;

                BatalhaClass batalha = new BatalhaClass(Jogador, james);

                Vencedor = batalha.IniciarBatalha();

                Console.Clear();

                if (Vencedor.Nome == james.Nome)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"\nP{james.Nome}");
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
