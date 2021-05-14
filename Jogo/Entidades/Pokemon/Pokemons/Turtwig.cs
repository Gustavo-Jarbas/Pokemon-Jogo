using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo.Entidades.Enums;
namespace Jogo.Entidades.Pokemon.Pokemons
{
    class Turtwig : PokemonClass
    {
        public Turtwig()
        {
            this.Nome = "Turtwig";
            this.TipoPokemon = Tipo.Planta;
            this.HpTotal = 15;
            this.HpAtual = 15;
            this.AtaqueBasico = 2;
            this.AtaqueBasicoTxt = "Rabada forte";
            this.Especial = 7;
            this.EspecialTxt = "Cabeçada KKKKKKK";
            this.Descricao = "Tartaruguinha fofinha";
        }
    }
    
    
}
