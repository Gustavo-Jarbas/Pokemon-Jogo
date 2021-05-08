using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using Jogo.Entidades;
using System.Media;



namespace Jogo.Entidades.FuncoesGame
{
    class Game
    {

        public static void Introducao()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                    _                             \n" +
                              "        _ __   ___ | | _____ _ __ ___   ___  _ __ \n" +
                              "       | '_ \\ / _ \\| |/ / _ \\ '_ ` _ \\ / _ \\| '_ \\ \n " +
                              "      | |_) | (_) |   < __ / | | | | | (_) | | | |\n" +
                              "       | .__/ \\___/|_|\\_\\___|_| |_| |_|\\___/|_| |_| \n" +
                              "       |_|\n\n" +
                          "       _   _          _                  /\\/\\ |\\               \n" +
                          "      | | | |  _ _   (_)  _ __           \\ \\ \\//               \n" +
                          "      | |_| | | ' \\  | | |'_  \\          / o_o\\                \n" +
                          "       \\___/  |_||_| |_| |.__ /          \\____/                 \n" +
                           "                         |_|             /_\\/_\\                 \n\n\n");

            Console.ResetColor();


        }



        public static void ImprimirTextos(string texto)
        {
            foreach (var letra in texto)
            {
                Console.Write(letra);
                Thread.Sleep(60);


            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Press qualquer tecla ...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Write("                         ");
        }




        public static void ImprimirDinheiro(double Dinheiro)
        {
            for (var din = 1; din <= Dinheiro; din++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"                                                                                                   |R$ {din}|");
                Thread.Sleep(20);

            }
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void Musicas(int escolha) { 
            var Inicial = new SoundPlayer(@"iniciar.wav");
            var Batalha = new SoundPlayer(@"batalha.wav");
            var Soco = new SoundPlayer(@"soco.wav");
        
            if (escolha == 1)
            {

                Inicial.PlayLooping();
            }
            if (escolha == 2)
            {

                Batalha.Play();
                
                
            }

      
        }

    }
}
