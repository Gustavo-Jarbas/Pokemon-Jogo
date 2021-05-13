using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo.Entidades.Enums;

namespace Jogo.Entidades.Pokemon.Pokemons
{
    class Squirtle : PokemonClass
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
