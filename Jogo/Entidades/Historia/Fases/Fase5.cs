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
    class Fase5
    {
        TreinadorClass Jogador;
        TreinadorClass Vencedor;
        int backupPocao;
        int backupPokeballs;
        public Fase5(TreinadorClass jogador)
        {
            Jogador = jogador;
        }


        public TreinadorClass Executar()
        {
            Musicas.TocarMusica(1);
            Inimigo5 inimigo = new Inimigo5();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"\n{inimigo.Nome}: ");
            Console.ResetColor();
            Textos.ImprimirTextos("\n NÃOOOOO, JASSE, JAMESS!\n");
            Textos.ImprimirTextos("\n Bem... Não tem problema... Eu o Poderoso Meowth junto com meu lendario Pokemon vamos acabar com você!!!\n");

            int revanche;

            do //isso daq vai ser padrão em todas praticamente, só mudar os numero dos inimigos.
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
