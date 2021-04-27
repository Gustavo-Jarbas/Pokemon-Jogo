using System;
using System.Collections.Generic;
using Jogo.Entidades;
using Jogo.Entidades.Enums;

namespace Jogo.Entidades.Pokemons
{
    class Bulbassauro : Pokemon
    {
        public Bulbassauro()
        {
            this.Nome = "Bulbassauro";
            this.TipoPokemon = Tipo.Planta;
            this.HpTotal = 24;
            this.AtaqueBasico = 2;
            this.AtaqueBasicoTxt = "Chicotada";
            this.Especial = 7;
            this.EspecialTxt = "Tempestade de folhas";
            this.Descricao = "Dinossauro maconheiro";
        }
    }
}
