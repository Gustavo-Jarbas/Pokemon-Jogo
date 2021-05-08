using System;
using System.Collections.Generic;
using Jogo.Entidades;
using Jogo.Entidades.Enums;

namespace Jogo.Entidades.Pokemons
{
    class Charmander : Pokemon
    {
        public Charmander()
        {
            this.Nome = "Charmander";
            this.TipoPokemon = Tipo.Fogo;
            this.HpTotal = 50;
            this.HpAtual = 50;
            this.AtaqueBasico = 3;
            this.AtaqueBasicoTxt = "Mordida";
            this.Especial = 5;
            this.EspecialTxt = "Bola de fogo";
            this.Descricao = "Dinossauro com fogo no rabo";
        }
    }
}


