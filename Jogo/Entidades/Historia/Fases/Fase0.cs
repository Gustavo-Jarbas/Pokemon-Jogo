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
    class Fase0
    {
        TreinadorClass Jogador;
        TreinadorClass Vencedor;
        int backupPocao;
        int backupPokeballs;
        public Fase0(TreinadorClass jogador1)
        {
            Jogador = jogador1;
        }


        public TreinadorClass Executar()
         {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nProfessor Pokemon: ");
            Console.ResetColor();
            var textos = new List<string>();
            textos.Add($"\n\nOlá jovem {Jogador.Nome} saudavel! desculpe por mantê-lo(a) esperando!\n\n\n");
            textos.Add("\nMeu nome é Ednaldo Pereira\n" + "Mas pode me chamar de Professor Pokémon, todo mundo me chama assim :D\n\n");
            textos.Add("\nNós humanos vivemos ao lado de Pokémons, às vezes como companheiros amistosos e\nàs vezes como colegas de trabalho cooperativos\n");
            textos.Add("\n\n\nEntão você está pronto para essa aventura? :)\n\n");

            foreach (var texto in textos)
            {
                Textos.ImprimirTextos(texto);
            }


            Console.Clear();
            Dinheiro.ImprimirDinheiro(Jogador);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nProfessor Pokemon: ");
            Console.ResetColor();
            Textos.ImprimirTextos($"\n\nVocê escolheu o tipo de Pokemon de {Jogador.Pokemons[0].TipoPokemon}, essa foi uma boa e fabulosa escolha" +
                    $"\nCom essa especialidade o nome de seu Pokemon é {Jogador.Pokemons[0].Nome} \n");
        
            Textos.ImprimirTextos("\n\nRepare que ao lado direito está seu dinheiro e conforme você ir vencendo batalhas vai ganhando mais e" +
            "\nutilizar para comprar Pokebolas e Poções de Cura\n");

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nProfessor Pokemon: ");
            Console.ResetColor();
            Textos.ImprimirTextos("\n\nComo voce parece ser legal estou te doando 3x Pokebolas e 3x Poções de Cura" +
                "\nUtileze elas com sabedoria, pois você só pode capturar um Pokemon do inimigo quando ele está com" +
                "\n30% de sua vida, e também não utilize as poções de cura atoa HUMMMM\n\n");
            Textos.ImprimirTextos("\n\nEntao... oque você acha de iniciarmos com um breve duelo para testar suas habilidades? \n\n");
         
            Textos.ImprimirTextos("\n\nTem um cara maluquinho da cabeça que está atacando a vila, vamos lá acabar com ele?\n\n");

            int revanche;

            do
            {
                revanche = 2;

                Console.Clear();
                Inimigo0 inimigo = new Inimigo0();

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

                    if(revanche == 1)
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
