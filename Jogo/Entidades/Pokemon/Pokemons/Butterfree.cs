using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo.Entidades.Enums;

namespace Jogo.Entidades.Pokemon.Pokemons
{
    class Butterfree : PokemonClass
    {
        public Butterfree()
        {
            this.Nome = "Butterfree";
            this.TipoPokemon = Tipo.Planta;
            this.HpTotal = 20;
            this.HpAtual = 20;
            this.AtaqueBasico = 2;
            this.AtaqueBasicoTxt = "Asas da sabedoria";
            this.Especial = 7;
            this.EspecialTxt = "MEEEEEEEE";
            this.Descricao = "Borboleta Gigante";
        }
    }
}
