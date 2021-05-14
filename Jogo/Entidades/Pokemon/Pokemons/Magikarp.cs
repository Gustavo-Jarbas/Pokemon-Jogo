using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo.Entidades.Enums;

namespace Jogo.Entidades.Pokemon.Pokemons
{
    class Magikarp : PokemonClass
    {
        public Magikarp()
        {
            this.Nome = "Magikarp";
            this.TipoPokemon = Tipo.Agua;
            this.HpTotal = 100;
            this.HpAtual = 100;
            this.AtaqueBasico = 0;
            this.AtaqueBasicoTxt = "olhar fixo";
            this.Especial = 1;
            this.EspecialTxt = "SUPER NADA";
            this.Descricao = "Pokemon lendario que domina os oceanos";
        }
    }
}
