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
        public static TreinadorClass jogador = new TreinadorClass();
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

            // FASE 0
            //-------------------------------------------
            fase0 = new Fase0(jogador);
            fase0.Executar();
            PosBatalha.Executar();
            //------------------------------------------------
                   



            //FASE 1
            fase1 = new Fase1(jogador);
            fase1.Executar();
            PosBatalha.Executar();
            //----------------------------------------------




            //FASE 2
            fase2 = new Fase2(jogador);
            fase2.Executar();
            PosBatalha.Executar();
            //----------------------------------------------


        }


    }
}
