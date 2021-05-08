using System;
using System.Collections.Generic;
using Jogo.Entidades;
using Jogo.Entidades.Enums;
using Jogo.Entidades.Pokemons;
using System.Media;
using Jogo.Entidades.FuncoesGame;

namespace Jogo.Entidades.Fases.Inimigos
{
    class Inimigo1 : Treinador
    {
        public Inimigo1()
        {
            this.Nome = "INIMIGO NUMERO UM";
            this.Dinheiro = 30;
            this.Pokemons.Add(new Charmander());
        }
    }
}
