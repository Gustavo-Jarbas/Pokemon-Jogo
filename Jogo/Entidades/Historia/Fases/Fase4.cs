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
    class Fase4
    {
        TreinadorClass Jogador;
        TreinadorClass Vencedor;
        int backupPocao;
        int backupPokeballs;
        public Fase4(TreinadorClass jogador)
        {
            Jogador = jogador;
        }


        public TreinadorClass Executar()
        {
            Musicas.TocarMusica(1);
            Inimigo4 inimigo = new Inimigo4();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"\n{inimigo.Nome}: ");
            Console.ResetColor();
            Textos.ImprimirTextos("\n Você ganhou do James, mas foi pura sorte, vou vingar ele agora! VENHA SEU MERDINHA\n");
           
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
