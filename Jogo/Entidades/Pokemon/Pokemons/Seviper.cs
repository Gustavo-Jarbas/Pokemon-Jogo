using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo.Entidades.Enums;

namespace Jogo.Entidades.Pokemon.Pokemons
{
    class Seviper : PokemonClass
    {
        public Seviper()
        {
            this.Nome = "Seviper";
            this.TipoPokemon = Tipo.Veneno;
            this.HpTotal = 45;
            this.HpAtual = 45;
            this.AtaqueBasico = 4;
            this.AtaqueBasicoTxt = "Cauda venenosa";
            this.Especial = 11;
            this.EspecialTxt = "Novem de Veneno";
            this.Descricao = "Cobra, só isso mesmo";
        }
    }
}
