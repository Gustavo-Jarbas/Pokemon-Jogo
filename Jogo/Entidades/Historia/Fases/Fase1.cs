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


        public TreinadorClass Executar() // unica parte q ue não é padrão é a historia.
        {
            //Texto da Historia  da Fase 1 vai estar aqui, igual na Fase 0

            int revanche;

            do //isso daq vai ser padrão em todas praticamente, só mudar os numero dos inimigos.
            {
                revanche = 2;

                Console.Clear();
                Inimigo1 inimigo = new Inimigo1(); 

                backupPocao = Jogador.Potion;
                backupPokeballs = Jogador.PokeBalls;

                BatalhaClass batalha = new BatalhaClass(Jogador, inimigo);

                Vencedor = batalha.IniciarBatalha();

                Console.Clear();

                if (Vencedor.Nome == inimigo.Nome)
                {
                    Textos.ImprimirTextos("\n\n\nParabéns seu perdedor, voce acaba de perder essa batalha. :'(");
                    Console.Write("\n\nMas não fique triste pq vamos te dar mais uma chance, deseja continuar?" +
                    "\n\n1 - Tentar novamente               2 - Desistir da vida \n" +
                    "\nR:");
                    revanche = int.Parse(Console.ReadLine());

                    if (revanche == 1)
                    {

                        Jogador.Potion = backupPocao;
                        Jogador.PokeBalls = backupPokeballs;

                    }
                }
            } while (revanche != 2);


            return Vencedor;
        }

    }
}
