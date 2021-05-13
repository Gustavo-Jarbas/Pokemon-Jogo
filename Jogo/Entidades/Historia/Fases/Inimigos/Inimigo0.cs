using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jogo.Entidades.Treinador;
using Jogo.Entidades.Pokemon.Pokemons;
using Jogo.Entidades.Pokemon;

namespace Jogo.Entidades.Historia.Fases.Inimigos
{
    class Inimigo0 : TreinadorClass
    {
        Squirtle squirtle = new Squirtle();
        public Inimigo0()
        {
            this.Nome = "Gary Carvalho";
            this.Pokemons.Add(squirtle);
            this.Dinheiro = 10;
        }
    }
}
