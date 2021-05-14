using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo.Entidades.Enums;

namespace Jogo.Entidades.Pokemon.Pokemons
{
    class Carnivine : PokemonClass
    {
        public Carnivine()
        {
            this.Nome = "Carnivine";
            this.TipoPokemon = Tipo.Planta;
            this.HpTotal = 30;
            this.HpAtual = 30;
            this.AtaqueBasico = 6;
            this.AtaqueBasicoTxt = "Mordida";
            this.Especial = 5;
            this.EspecialTxt = "Metralhadora de Sementes";
            this.Descricao = "Planta Carnivora";
        }
    }
}
