using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Jogo.Entidades.Estaticos
{
    class Musicas
    {
        public static void TocarMusica(int escolha)
        {
            var Inicial = new SoundPlayer(@"iniciar.wav");
            var Batalha = new SoundPlayer(@"batalha.wav");
            var Soco = new SoundPlayer(@"soco.wav");

            if (escolha == 1)
            {
                Inicial.PlayLooping(); //Deu erro aqui pois está sem as musicas, baixe as musicas do drive e coloque na pasta net5.0 (recomendo baixar o volume quando executar o programa e.e)
            }
            if (escolha == 2)
            {
                Batalha.PlayLooping();
            }

        }
    }
}
