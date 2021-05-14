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
    class Inimigo4 : TreinadorClass
    {
        Seviper seviper = new Seviper();
        public Inimigo4()
        {
            this.Nome = "Jassie";
            this.Pokemons.Add(seviper);
            this.Dinheiro = 15;
        }
    }
}
