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
            this.HpTotal = 20;
            this.AtaqueBasico = 3;
            this.Especial = 5;
            this.Descricao = "Dinossauro com fogo no rabo";
        }
    }
}


