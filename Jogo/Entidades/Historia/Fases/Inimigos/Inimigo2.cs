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
    class Inimigo2 : TreinadorClass
    {

        Butterfree butterfree = new Butterfree();
        public Inimigo2()
        {
            this.Nome = "Richie";
            this.Pokemons.Add(butterfree);
            this.Dinheiro = 20;
        }
    }
}
