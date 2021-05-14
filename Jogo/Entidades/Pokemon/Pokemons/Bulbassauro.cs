﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo.Entidades.Enums;

namespace Jogo.Entidades.Pokemon.Pokemons
{
    class Bulbassauro : PokemonClass
    {
        public Bulbassauro()
        {
            this.Nome = "Bulbassauro";
            this.TipoPokemon = Tipo.Planta;
            this.HpTotal = 25;
            this.HpAtual = 25;
            this.AtaqueBasico = 2;
            this.AtaqueBasicoTxt = "Chicotada";
            this.Especial = 7;
            this.EspecialTxt = "Tempestade de folhas";
            this.Descricao = "Dinossauro maconheiro";
        }
    }
}
