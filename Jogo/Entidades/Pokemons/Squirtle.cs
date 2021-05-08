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
            this.HpAtual = 15;
            this.AtaqueBasico = 6;
            this.AtaqueBasicoTxt = "SOCÃO";
            this.Especial = 5;
            this.EspecialTxt = "Bolhas";
            this.Descricao = "Tartaruga Azul";
        }
    }
}
