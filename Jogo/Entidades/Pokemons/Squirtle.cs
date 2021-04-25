using System;
using System.Collections.Generic;
using Jogo.Entidades;
using Jogo.Entidades.Enums;

namespace Jogo.Entidades.Pokemons
{
    class Squirtle : Pokemon
    {
        public Squirtle()
        {
            this.Nome = "Squirtle";
            this.TipoPokemon = Tipo.Agua;
            this.HpTotal = 15;
            this.AtaqueBasico = 6;
            this.Especial = 5;
            this.Descricao = "Tartaruga Azul";
        }
    }
}
