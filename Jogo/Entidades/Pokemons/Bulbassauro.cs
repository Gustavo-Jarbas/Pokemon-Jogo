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
            this.Especial = 7;
            this.Descricao = "Dinossauro maconheiro";
        }
    }
}
