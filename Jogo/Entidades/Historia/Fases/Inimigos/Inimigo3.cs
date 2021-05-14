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
    class Inimigo3 : TreinadorClass
    {
        Carnivine carnivine = new Carnivine();
        public Inimigo3()
        {
            this.Nome = "James";
            this.Pokemons.Add(carnivine);
            this.Dinheiro = 25;
        }
    }
}
