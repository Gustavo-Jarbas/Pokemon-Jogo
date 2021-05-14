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
    class Inimigo5 : TreinadorClass
    {
        Magikarp magikarp = new Magikarp();
        public Inimigo5()
        {
            this.Nome = "Meowth";
            this.Pokemons.Add(magikarp);
            this.Dinheiro = 50;
        }
    }
}
