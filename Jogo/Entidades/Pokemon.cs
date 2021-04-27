using System;
using System.Collections.Generic;
using Jogo.Entidades.Enums;


namespace Jogo.Entidades
{
    class Pokemon // Super Classe
    {
        public string Nome { get; set; }
        public Tipo TipoPokemon { get; set; }
        public int HpTotal { get; set; }
        public int HpAtual { get; set; }
        public int AtaqueBasico { get; set; }
        public string AtaqueBasicoTxt { get; set; }
        public int Especial { get; set; }
        public string EspecialTxt { get; set; }
        public string Descricao { get; set; }


        public Pokemon()
        {
        }

        public Pokemon(string nome, Tipo tipoPokemon, int hpTotal, int hpAtual, int ataqueBasico, int especial, string descricao)
        {
            Nome = nome;
            TipoPokemon = tipoPokemon;
            HpTotal = hpTotal;
            HpAtual = hpAtual;
            AtaqueBasico = ataqueBasico;
            Especial = especial;
            Descricao = descricao;
        }



    }
}
